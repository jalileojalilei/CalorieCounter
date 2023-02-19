﻿namespace CalorieCounterPresentation.AdminUI
{
    partial class AdminStatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NN = new System.Windows.Forms.Button();
            this.NN2 = new System.Windows.Forms.Button();
            this.AdminStatsFormUserDgv = new System.Windows.Forms.DataGridView();
            this.AdminStatsFormUsersMealDgv = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AdminStatsFormLabel1 = new System.Windows.Forms.Label();
            this.FoodVarietyButton = new System.Windows.Forms.Button();
            this.UserStatsFormFoodCategoryButton = new System.Windows.Forms.Button();
            this.UserStatFormWeeklyMealCompare = new System.Windows.Forms.Button();
            this.UserStatFormMonthlyMealCompare = new System.Windows.Forms.Button();
            this.UserStatsFormMonthlyButton = new System.Windows.Forms.Button();
            this.UserStatsFormWeeklyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminStatsFormUserDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminStatsFormUsersMealDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.Gray;
            this.BackButton.Location = new System.Drawing.Point(713, 453);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 35);
            this.BackButton.TabIndex = 29;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.Gray;
            this.CloseButton.Location = new System.Drawing.Point(747, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 35);
            this.CloseButton.TabIndex = 30;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NN
            // 
            this.NN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.NN.FlatAppearance.BorderSize = 0;
            this.NN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NN.Location = new System.Drawing.Point(12, 12);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(729, 35);
            this.NN.TabIndex = 31;
            this.NN.Text = "Stats";
            this.NN.UseVisualStyleBackColor = false;
            // 
            // NN2
            // 
            this.NN2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.NN2.FlatAppearance.BorderSize = 0;
            this.NN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NN2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.NN2.Location = new System.Drawing.Point(69, 268);
            this.NN2.Name = "NN2";
            this.NN2.Size = new System.Drawing.Size(673, 10);
            this.NN2.TabIndex = 65;
            this.NN2.UseVisualStyleBackColor = false;
            // 
            // AdminStatsFormUserDgv
            // 
            this.AdminStatsFormUserDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdminStatsFormUserDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminStatsFormUserDgv.Location = new System.Drawing.Point(12, 84);
            this.AdminStatsFormUserDgv.Name = "AdminStatsFormUserDgv";
            this.AdminStatsFormUserDgv.RowTemplate.Height = 25;
            this.AdminStatsFormUserDgv.Size = new System.Drawing.Size(592, 168);
            this.AdminStatsFormUserDgv.TabIndex = 71;
            this.AdminStatsFormUserDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminStatsFormUserDgv_CellContentClick);
            // 
            // AdminStatsFormUsersMealDgv
            // 
            this.AdminStatsFormUsersMealDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdminStatsFormUsersMealDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminStatsFormUsersMealDgv.Location = new System.Drawing.Point(12, 284);
            this.AdminStatsFormUsersMealDgv.Name = "AdminStatsFormUsersMealDgv";
            this.AdminStatsFormUsersMealDgv.RowTemplate.Height = 25;
            this.AdminStatsFormUsersMealDgv.Size = new System.Drawing.Size(729, 163);
            this.AdminStatsFormUsersMealDgv.TabIndex = 72;
            this.AdminStatsFormUsersMealDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminStatsFormUsersMealDgv_CellContentClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.Gray;
            this.UpdateButton.Location = new System.Drawing.Point(632, 453);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 35);
            this.UpdateButton.TabIndex = 73;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // AdminStatsFormLabel1
            // 
            this.AdminStatsFormLabel1.AutoSize = true;
            this.AdminStatsFormLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminStatsFormLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.AdminStatsFormLabel1.Location = new System.Drawing.Point(12, 62);
            this.AdminStatsFormLabel1.Name = "AdminStatsFormLabel1";
            this.AdminStatsFormLabel1.Size = new System.Drawing.Size(54, 19);
            this.AdminStatsFormLabel1.TabIndex = 63;
            this.AdminStatsFormLabel1.Text = "Users";
            // 
            // FoodVarietyButton
            // 
            this.FoodVarietyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.FoodVarietyButton.FlatAppearance.BorderSize = 0;
            this.FoodVarietyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodVarietyButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodVarietyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.FoodVarietyButton.Location = new System.Drawing.Point(610, 229);
            this.FoodVarietyButton.Name = "FoodVarietyButton";
            this.FoodVarietyButton.Size = new System.Drawing.Size(131, 31);
            this.FoodVarietyButton.TabIndex = 91;
            this.FoodVarietyButton.Text = "Food Variety";
            this.FoodVarietyButton.UseVisualStyleBackColor = false;
            this.FoodVarietyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserStatsFormFoodCategoryButton
            // 
            this.UserStatsFormFoodCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.UserStatsFormFoodCategoryButton.FlatAppearance.BorderSize = 0;
            this.UserStatsFormFoodCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserStatsFormFoodCategoryButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserStatsFormFoodCategoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.UserStatsFormFoodCategoryButton.Location = new System.Drawing.Point(610, 53);
            this.UserStatsFormFoodCategoryButton.Name = "UserStatsFormFoodCategoryButton";
            this.UserStatsFormFoodCategoryButton.Size = new System.Drawing.Size(131, 28);
            this.UserStatsFormFoodCategoryButton.TabIndex = 90;
            this.UserStatsFormFoodCategoryButton.Text = "End Of Day";
            this.UserStatsFormFoodCategoryButton.UseVisualStyleBackColor = false;
            this.UserStatsFormFoodCategoryButton.Click += new System.EventHandler(this.AdminEndofDayButton_Click);
            // 
            // UserStatFormWeeklyMealCompare
            // 
            this.UserStatFormWeeklyMealCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.UserStatFormWeeklyMealCompare.FlatAppearance.BorderSize = 0;
            this.UserStatFormWeeklyMealCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserStatFormWeeklyMealCompare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserStatFormWeeklyMealCompare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.UserStatFormWeeklyMealCompare.Location = new System.Drawing.Point(610, 84);
            this.UserStatFormWeeklyMealCompare.Name = "UserStatFormWeeklyMealCompare";
            this.UserStatFormWeeklyMealCompare.Size = new System.Drawing.Size(131, 30);
            this.UserStatFormWeeklyMealCompare.TabIndex = 89;
            this.UserStatFormWeeklyMealCompare.Text = "Meal Weekly";
            this.UserStatFormWeeklyMealCompare.UseVisualStyleBackColor = false;
            this.UserStatFormWeeklyMealCompare.Click += new System.EventHandler(this.UserStatFormWeeklyMealCompare_Click);
            // 
            // UserStatFormMonthlyMealCompare
            // 
            this.UserStatFormMonthlyMealCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.UserStatFormMonthlyMealCompare.FlatAppearance.BorderSize = 0;
            this.UserStatFormMonthlyMealCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserStatFormMonthlyMealCompare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserStatFormMonthlyMealCompare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.UserStatFormMonthlyMealCompare.Location = new System.Drawing.Point(610, 120);
            this.UserStatFormMonthlyMealCompare.Name = "UserStatFormMonthlyMealCompare";
            this.UserStatFormMonthlyMealCompare.Size = new System.Drawing.Size(131, 30);
            this.UserStatFormMonthlyMealCompare.TabIndex = 88;
            this.UserStatFormMonthlyMealCompare.Text = "Meal Monthly";
            this.UserStatFormMonthlyMealCompare.UseVisualStyleBackColor = false;
            this.UserStatFormMonthlyMealCompare.Click += new System.EventHandler(this.UserStatFormMonthlyMealCompare_Click);
            // 
            // UserStatsFormMonthlyButton
            // 
            this.UserStatsFormMonthlyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.UserStatsFormMonthlyButton.FlatAppearance.BorderSize = 0;
            this.UserStatsFormMonthlyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserStatsFormMonthlyButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserStatsFormMonthlyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.UserStatsFormMonthlyButton.Location = new System.Drawing.Point(610, 156);
            this.UserStatsFormMonthlyButton.Name = "UserStatsFormMonthlyButton";
            this.UserStatsFormMonthlyButton.Size = new System.Drawing.Size(131, 31);
            this.UserStatsFormMonthlyButton.TabIndex = 87;
            this.UserStatsFormMonthlyButton.Text = "Category Weekly";
            this.UserStatsFormMonthlyButton.UseVisualStyleBackColor = false;
            this.UserStatsFormMonthlyButton.Click += new System.EventHandler(this.UserStatsFormMonthlyButton_Click);
            // 
            // UserStatsFormWeeklyButton
            // 
            this.UserStatsFormWeeklyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.UserStatsFormWeeklyButton.FlatAppearance.BorderSize = 0;
            this.UserStatsFormWeeklyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserStatsFormWeeklyButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserStatsFormWeeklyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.UserStatsFormWeeklyButton.Location = new System.Drawing.Point(610, 193);
            this.UserStatsFormWeeklyButton.Name = "UserStatsFormWeeklyButton";
            this.UserStatsFormWeeklyButton.Size = new System.Drawing.Size(131, 31);
            this.UserStatsFormWeeklyButton.TabIndex = 86;
            this.UserStatsFormWeeklyButton.Text = "Category Monthly";
            this.UserStatsFormWeeklyButton.UseVisualStyleBackColor = false;
            this.UserStatsFormWeeklyButton.Click += new System.EventHandler(this.UserStatsFormWeeklyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(12, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 92;
            this.label1.Text = "Users";
            // 
            // AdminStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoodVarietyButton);
            this.Controls.Add(this.UserStatsFormFoodCategoryButton);
            this.Controls.Add(this.UserStatFormWeeklyMealCompare);
            this.Controls.Add(this.UserStatFormMonthlyMealCompare);
            this.Controls.Add(this.UserStatsFormMonthlyButton);
            this.Controls.Add(this.UserStatsFormWeeklyButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AdminStatsFormUsersMealDgv);
            this.Controls.Add(this.AdminStatsFormUserDgv);
            this.Controls.Add(this.NN2);
            this.Controls.Add(this.AdminStatsFormLabel1);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminStatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStatsForm";
            this.Load += new System.EventHandler(this.AdminStatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminStatsFormUserDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminStatsFormUsersMealDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackButton;
        private Button CloseButton;
        private Button NN;
        private Button NN2;
        private DataGridView AdminStatsFormUserDgv;
        private DataGridView AdminStatsFormUsersMealDgv;
        private Button UpdateButton;
        private Label AdminStatsFormLabel1;
        private Button FoodVarietyButton;
        private Button UserStatsFormFoodCategoryButton;
        private Button UserStatFormWeeklyMealCompare;
        private Button UserStatFormMonthlyMealCompare;
        private Button UserStatsFormMonthlyButton;
        private Button UserStatsFormWeeklyButton;
        private Label label1;
    }
}