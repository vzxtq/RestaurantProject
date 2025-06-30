using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Dish> dishes = new List<Dish>();
        private List<Order> orders = new List<Order>();
        private int nextOrderId = 1;
        private Order selectedOrder = null;
        private List<User> users = new List<User>();
        private User selectedUser = null;
        private Address selectedAddress = null;
        private bool isPickup = true;
        private List<Dish> filteredDishes = new List<Dish>();

        public Form1()
        {
            InitializeComponent();
            InitializeGridColumns();
            filteredDishes = new List<Dish>(dishes);
            RefreshDishGrid();
            RefreshOrderList();
            RefreshUserList();
            lstOrders.SelectedIndexChanged += lstOrders_SelectedIndexChanged;
            UpdateOrderControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string priceText = txtPrice.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText))
            {
                MessageBox.Show("Please enter both the name and price of the dish.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            Dish newDish = new Dish
            {
                Name = name,
                Description = description,
                Price = price
            };

            dishes.Add(newDish);
            ApplySearchFilter();
            ClearInputs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dgvDishes.CurrentRow?.Index ?? -1;
            var list = GetCurrentDishList();
            if (index >= 0 && index < list.Count)
            {
                var dishToRemove = list[index];
                dishes.Remove(dishToRemove);
                ApplySearchFilter();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Select a dish to remove.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dgvDishes.CurrentRow?.Index ?? -1;
            var list = GetCurrentDishList();
            if (index >= 0 && index < list.Count)
            {
                string name = txtName.Text.Trim();
                string description = txtDescription.Text.Trim();
                string priceText = txtPrice.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText))
                {
                    MessageBox.Show("Please enter both the name and price.");
                    return;
                }

                if (!decimal.TryParse(priceText, out decimal price))
                {
                    MessageBox.Show("Price must be a valid number.");
                    return;
                }

                Dish dish = list[index];
                dish.Name = name;
                dish.Description = description;
                dish.Price = price;

                ApplySearchFilter();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Select a dish to edit.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "XML Files (*.xml)|*.xml",
                    Title = "Save Dish List"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Dish>));
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        serializer.Serialize(fs, dishes);
                    }

                    MessageBox.Show("Dishes saved successfully.");
                    toolStripStatusLabel.Text = "Saved to file.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "XML Files (*.xml)|*.xml",
                    Title = "Open Dish List"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Dish>));
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        var loadedDishes = (List<Dish>)serializer.Deserialize(fs);
                        dishes = loadedDishes ?? new List<Dish>();
                    }

                    ApplySearchFilter();
                    toolStripStatusLabel.Text = "Loaded from file.";
                    MessageBox.Show("Dishes loaded successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a user name.");
                return;
            }
            users.Add(new User { Name = name });
            txtUserName.Clear();
            RefreshUserList();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (selectedUser == null) return;
            string name = Prompt.ShowDialog("Edit user name:", "Edit User", selectedUser.Name);
            if (!string.IsNullOrWhiteSpace(name))
            {
                selectedUser.Name = name;
                RefreshUserList();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUser == null) return;
            users.Remove(selectedUser);
            selectedUser = null;
            RefreshUserList();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUser = cmbUsers.SelectedItem as User;
            RefreshAddressList();
            UpdateOrderControls();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }
            string label = txtAddressLabel.Text.Trim();
            string details = txtAddressDetails.Text.Trim();
            if (string.IsNullOrWhiteSpace(label) || string.IsNullOrWhiteSpace(details))
            {
                MessageBox.Show("Please enter both label and address details.");
                return;
            }

            decimal cost = 1.00m;
            if (label.ToLower().Contains("work")) cost = 2.00m;
            else if (!label.ToLower().Contains("home")) cost = 3.00m;

            selectedUser.Addresses.Add(new Address { Label = label, Details = details, DeliveryCost = cost });
            txtAddressLabel.Clear();
            txtAddressDetails.Clear();
            RefreshAddressList();
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            if (selectedUser == null || selectedAddress == null) return;
            string label = Prompt.ShowDialog("Label:", "Edit Address", selectedAddress.Label);
            string details = Prompt.ShowDialog("Details:", "Edit Address", selectedAddress.Details);
            if (string.IsNullOrWhiteSpace(label) || string.IsNullOrWhiteSpace(details)) return;

            decimal cost = 1.00m;
            if (label.ToLower().Contains("work")) cost = 2.00m;
            else if (!label.ToLower().Contains("home")) cost = 3.00m;

            selectedAddress.Label = label;
            selectedAddress.Details = details;
            selectedAddress.DeliveryCost = cost;
            RefreshAddressList();
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            if (selectedUser == null || selectedAddress == null) return;
            selectedUser.Addresses.Remove(selectedAddress);
            selectedAddress = null;
            RefreshAddressList();
        }

        private void cmbAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAddress = cmbAddresses.SelectedItem as Address;
            UpdateDeliveryCost();
            UpdateOrderControls();
        }

        private void rdoPickup_CheckedChanged(object sender, EventArgs e)
        {
            isPickup = rdoPickup.Checked;
            UpdateDeliveryCost();
        }

        private void rdoDelivery_CheckedChanged(object sender, EventArgs e)
        {
            isPickup = !rdoPickup.Checked;
            UpdateDeliveryCost();
        }

        private void UpdateDeliveryCost()
        {
            if (isPickup)
                lblDeliveryCost.Text = "Pickup selected. No delivery cost.";
            else if (selectedAddress != null)
                lblDeliveryCost.Text = $"Delivery cost: {selectedAddress.DeliveryCost:C}";
            else
                lblDeliveryCost.Text = "Select a delivery address.";
        }

        private void RefreshUserList()
        {
            cmbUsers.DataSource = null;
            cmbUsers.DataSource = users;
            if (users.Count > 0) cmbUsers.SelectedIndex = 0;
            UpdateOrderControls();
        }

        private void RefreshAddressList()
        {
            cmbAddresses.DataSource = null;
            cmbAddresses.DataSource = selectedUser?.Addresses;
            if (selectedUser?.Addresses.Count > 0) cmbAddresses.SelectedIndex = 0;
            UpdateOrderControls();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please create and select a user before creating an order.");
                return;
            }
            if (selectedAddress == null)
            {
                MessageBox.Show("Please add and select a delivery address before creating an order.");
                return;
            }
            if (dgvDishes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select at least one dish to order.");
                return;
            }

            var selectedDishes = new List<Dish>();
            var list = GetCurrentDishList();
            foreach (DataGridViewRow row in dgvDishes.SelectedRows)
            {
                int index = row.Index;
                if (index >= 0 && index < list.Count)
                {
                    selectedDishes.Add(list[index]);
                }
            }

            if (selectedDishes.Count == 0)
            {
                MessageBox.Show("No valid dishes selected.");
                return;
            }

            decimal deliveryCost = (!isPickup && selectedAddress != null) ? selectedAddress.DeliveryCost : 0;

            var order = new Order
            {
                Id = nextOrderId++,
                Dishes = selectedDishes,
                DeliveryCost = deliveryCost,
                Status = OrderStatus.Received
            };
            orders.Add(order);
            RefreshOrderList();
            MessageBox.Show($"Order #{order.Id} created.");
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null || selectedOrder.IsCancelled)
            {
                MessageBox.Show("Select an active order to edit.");
                return;
            }
            selectedOrder.Dishes = new List<Dish>(dishes);
            RefreshOrderList();
            MessageBox.Show($"Order #{selectedOrder.Id} updated.");
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null || selectedOrder.IsCancelled)
            {
                MessageBox.Show("Select an active order to cancel.");
                return;
            }
            selectedOrder.IsCancelled = true;
            RefreshOrderList();
            MessageBox.Show($"Order #{selectedOrder.Id} cancelled.");
        }

        private void btnShowReceipt_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                MessageBox.Show("Select an order to view receipt.");
                return;
            }
            string receipt = $"Order #{selectedOrder.Id}\nDate: {selectedOrder.CreatedAt}\nStatus: {selectedOrder.Status}\n\n";
            foreach (var dish in selectedOrder.Dishes)
                receipt += $"{dish.Name} - {dish.Price:C}\n";
            if (selectedOrder.DeliveryCost > 0)
                receipt += $"\nDelivery: {selectedOrder.DeliveryCost:C}\n";
            receipt += $"\nTotal: {selectedOrder.Total:C}\n";
            receipt += selectedOrder.IsCancelled ? "\n[Cancelled]" : "";
            MessageBox.Show(receipt, "Order Receipt");
        }

        private void btnAddDishComment_Click(object sender, EventArgs e)
        {
            var list = GetCurrentDishList();
            int index = dgvDishes.CurrentRow?.Index ?? -1;
            if (index < 0 || index >= list.Count)
            {
                MessageBox.Show("Select a dish to comment.");
                return;
            }
            var dish = list[index];
            string comment = txtDishComment.Text.Trim();
            int score = 0;
            if (cmbDishScore.SelectedItem != null)
                int.TryParse(cmbDishScore.SelectedItem.ToString(), out score);

            if (string.IsNullOrWhiteSpace(comment) && score == 0)
            {
                MessageBox.Show("Enter a comment or select a score.");
                return;
            }

            if (dish.Comments == null)
                dish.Comments = new List<DishComment>();

            dish.Comments.Add(new DishComment
            {
                User = selectedUser?.Name ?? "Anonymous",
                Comment = comment,
                Score = score,
                Date = DateTime.Now
            });

            txtDishComment.Clear();
            cmbDishScore.SelectedIndex = -1;
            RefreshDishComments();
        }

        private void RefreshDishComments()
        {
            lstDishComments.Items.Clear();
            var list = GetCurrentDishList();
            int index = dgvDishes.CurrentRow?.Index ?? -1;
            if (index < 0 || index >= list.Count)
                return;
            var dish = list[index];
            if (dish.Comments != null)
            {
                foreach (var c in dish.Comments)
                {
                    lstDishComments.Items.Add($"{c.User}: {c.Comment} (Score: {c.Score}) [{c.Date:g}]");
                }
            }
        }

        private void dgvDishes_SelectionChanged(object sender, EventArgs e)
        {
            var list = GetCurrentDishList();
            if (dgvDishes.CurrentRow?.Index >= 0 && dgvDishes.CurrentRow.Index < list.Count)
            {
                Dish selected = list[dgvDishes.CurrentRow.Index];
                txtName.Text = selected.Name;
                txtDescription.Text = selected.Description;
                txtPrice.Text = selected.Price.ToString();
            }
            RefreshDishComments();
            UpdateOrderControls();
        }

        private void cmbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedOrder == null) return;
            if (cmbOrderStatus.SelectedItem is string statusStr)
            {
                if (Enum.TryParse<OrderStatus>(statusStr.Replace(" ", ""), true, out var status))
                {
                    selectedOrder.Status = status;
                    RefreshOrderList();
                }
            }
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrder = lstOrders.SelectedItem as Order;
            if (selectedOrder != null)
            {
                cmbOrderStatus.SelectedItem = selectedOrder.Status.ToString().Replace("InDelivery", "In Delivery");
            }
        }

        private void RefreshOrderList()
        {
            lstOrders.DataSource = null;
            lstOrders.DataSource = orders;
            if (orders.Count > 0)
            {
                lstOrders.SelectedIndex = 0;
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            dgvDishes.ClearSelection();
        }

        private void InitializeGridColumns()
        {
            dgvDishes.Columns.Clear();
            dgvDishes.Columns.Add("Name", "Name");
            dgvDishes.Columns.Add("Description", "Description");
            dgvDishes.Columns.Add("Price", "Price");
        }

        private void RefreshDishGrid()
        {
            dgvDishes.Rows.Clear();
            var list = GetCurrentDishList();
            foreach (var dish in list)
            {
                dgvDishes.Rows.Add(dish.Name, dish.Description, dish.Price.ToString("C"));
            }
            toolStripStatusLabel.Text = $"Total Dishes: {list.Count}";
        }

        private void UpdateOrderControls()
        {
            bool userSelected = selectedUser != null;
            bool addressSelected = selectedAddress != null;
            bool dishesSelected = dgvDishes.SelectedRows.Count > 0;

            btnCreateOrder.Enabled = userSelected && addressSelected && dishesSelected;
            cmbAddresses.Enabled = userSelected;
            btnAddAddress.Enabled = userSelected;
            btnEditAddress.Enabled = addressSelected;
            btnDeleteAddress.Enabled = addressSelected;
            rdoPickup.Enabled = userSelected;
            rdoDelivery.Enabled = userSelected && addressSelected;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void ApplySearchFilter()
        {
            string pattern = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(pattern))
            {
                filteredDishes = new List<Dish>(dishes);
            }
            else
            {
                try
                {
                    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    filteredDishes = dishes.Where(d =>
                        regex.IsMatch(d.Name ?? "") ||
                        regex.IsMatch(d.Description ?? "") ||
                        regex.IsMatch(d.Price.ToString())
                    ).ToList();
                }
                catch
                {
                    filteredDishes = new List<Dish>();
                }
            }
            RefreshDishGrid();
        }

        private List<Dish> GetCurrentDishList()
        {
            if (txtSearch != null && !string.IsNullOrEmpty(txtSearch.Text))
                return filteredDishes;
            return dishes;
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            var list = GetCurrentDishList();
            int index = dgvDishes.CurrentRow?.Index ?? -1;
            if (index < 0 || index >= list.Count)
            {
                MessageBox.Show("Select a dish to upload photos.");
                return;
            }
            var dish = list[index];

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Food Photos";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                dlg.Multiselect = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in dlg.FileNames)
                    {
                        dish.ImagePaths.Add(file);
                    }
                    ShowDishImages(dish);
                }
            }
        }

        private void ShowDishImages(Dish dish)
        {
            flowGallery.Controls.Clear();
            foreach (var path in dish.ImagePaths)
            {
                try
                {
                    var pic = new PictureBox
                    {
                        Image = System.Drawing.Image.FromFile(path),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 150,
                        Height = 100,
                        Margin = new Padding(5)
                    };
                    flowGallery.Controls.Add(pic);
                }
                catch
                {
                }
            }
        }
    }

    public class DishComment
    {
        public string User { get; set; }
        public string Comment { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }

    public class Dish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<DishComment> Comments { get; set; } = new List<DishComment>();
        public List<string> ImagePaths { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }

    public enum OrderStatus
    {
        Received,
        Confirmed,
        Preparing,
        InDelivery,
        Delivered
    }

    public class Order
    {
        public int Id { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsCancelled { get; set; }
        public decimal DeliveryCost { get; set; }
        public decimal Total => Dishes.Sum(d => d.Price) + DeliveryCost;
        public OrderStatus Status { get; set; } = OrderStatus.Received;

        public override string ToString()
        {
            string statusStr = IsCancelled ? "Cancelled" : Status.ToString();
            return $"Order #{Id} - {CreatedAt:g} - {statusStr}";
        }
    }

    public class User
    {
        public string Name { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public override string ToString() => Name;
    }

    public class Address
    {
        public string Label { get; set; }
        public string Details { get; set; }
        public decimal DeliveryCost { get; set; }
        public override string ToString() => $"{Label}: {Details} ({DeliveryCost:C})";
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form() { Width = 400, Height = 150, Text = caption };
            Label lbl = new Label() { Left = 20, Top = 20, Text = text, Width = 340 };
            TextBox txt = new TextBox() { Left = 20, Top = 50, Width = 340, Text = defaultValue };
            Button ok = new Button() { Text = "OK", Left = 200, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancel", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };
            prompt.Controls.Add(lbl); prompt.Controls.Add(txt); prompt.Controls.Add(ok); prompt.Controls.Add(cancel);
            prompt.AcceptButton = ok; prompt.CancelButton = cancel;
            return prompt.ShowDialog() == DialogResult.OK ? txt.Text : null;
        }
    }
}