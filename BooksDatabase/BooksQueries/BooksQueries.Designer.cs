﻿//Victor Espinoza
//CECS 475 - Application Programming using .NET
//Assignment #4 - Database Entity Model
//Due: 2/23/16
namespace BooksQueries {
   partial class BooksQueries {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // outputTextBox
         // 
         this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.outputTextBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.outputTextBox.Location = new System.Drawing.Point(-4, 12);
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.outputTextBox.Size = new System.Drawing.Size(749, 358);
         this.outputTextBox.TabIndex = 1;
         this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
         // 
         // BooksQueries
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(773, 382);
         this.Controls.Add(this.outputTextBox);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "BooksQueries";
         this.Text = "Joining Tables with LINQ";
         this.Load += new System.EventHandler(this.BooksQueries_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox outputTextBox;
   }
}

