namespace RestaurantPart5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            userName = new TextBox();
            cmbxDrinks = new ComboBox();
            countEgg = new TextBox();
            countChicken = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnNewRequest = new Button();
            sendOrderToCook = new Button();
            orderList = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(userName);
            groupBox1.Controls.Add(cmbxDrinks);
            groupBox1.Controls.Add(countEgg);
            groupBox1.Controls.Add(countChicken);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // userName
            // 
            userName.Location = new Point(389, 102);
            userName.Name = "userName";
            userName.Size = new Size(323, 43);
            userName.TabIndex = 4;
            // 
            // cmbxDrinks
            // 
            cmbxDrinks.FormattingEnabled = true;
            cmbxDrinks.Location = new Point(402, 46);
            cmbxDrinks.Name = "cmbxDrinks";
            cmbxDrinks.Size = new Size(310, 45);
            cmbxDrinks.TabIndex = 3;
            // 
            // countEgg
            // 
            countEgg.Location = new Point(266, 107);
            countEgg.Name = "countEgg";
            countEgg.Size = new Size(41, 43);
            countEgg.TabIndex = 2;
            // 
            // countChicken
            // 
            countChicken.Location = new Point(313, 53);
            countChicken.Name = "countChicken";
            countChicken.Size = new Size(41, 43);
            countChicken.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 107);
            label2.Name = "label2";
            label2.Size = new Size(217, 38);
            label2.TabIndex = 1;
            label2.Text = "How Many Egg?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 53);
            label1.Name = "label1";
            label1.Size = new Size(276, 38);
            label1.TabIndex = 0;
            label1.Text = "How Many Chiicken?";
            // 
            // btnNewRequest
            // 
            btnNewRequest.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnNewRequest.Location = new Point(55, 211);
            btnNewRequest.Name = "btnNewRequest";
            btnNewRequest.Size = new Size(681, 49);
            btnNewRequest.TabIndex = 1;
            btnNewRequest.Text = "Recive new Request to the Customer ";
            btnNewRequest.UseVisualStyleBackColor = true;
            btnNewRequest.Click += btnNewRequest_Click;
            // 
            // sendOrderToCook
            // 
            sendOrderToCook.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sendOrderToCook.Location = new Point(55, 283);
            sendOrderToCook.Name = "sendOrderToCook";
            sendOrderToCook.Size = new Size(681, 49);
            sendOrderToCook.TabIndex = 2;
            sendOrderToCook.Text = "Send all Order To Cook";
            sendOrderToCook.UseVisualStyleBackColor = true;
            sendOrderToCook.Click += sendOrderToCook_Click;
            // 
            // orderList
            // 
            orderList.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            orderList.FormattingEnabled = true;
            orderList.ItemHeight = 37;
            orderList.Location = new Point(24, 354);
            orderList.Name = "orderList";
            orderList.Size = new Size(735, 189);
            orderList.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 546);
            Controls.Add(orderList);
            Controls.Add(sendOrderToCook);
            Controls.Add(btnNewRequest);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox userName;
        private ComboBox cmbxDrinks;
        private TextBox countEgg;
        private TextBox countChicken;
        private Label label2;
        private Label label1;
        private Button btnNewRequest;
        private Button sendOrderToCook;
        private ListBox orderList;
    }
}
