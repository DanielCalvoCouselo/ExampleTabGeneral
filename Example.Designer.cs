
namespace WindowsFormsApp1
{
    partial class Example
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
            this.swCodi1 = new SC_CustomControls.SWCodi();
            this.swTextbox2 = new SC_CustomControls.SWTextbox();
            this.swTextbox3 = new SC_CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // swCodi1
            // 
            this.swCodi1.ClaseCS = null;
            this.swCodi1.controlID = "swTextbox3";
            this.swCodi1.FormCS = null;
            this.swCodi1.Location = new System.Drawing.Point(33, 292);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.Nomcodi = "codeOrder";
            this.swCodi1.NomDesc = "dateOrder";
            this.swCodi1.NomId = "idOrder";
            this.swCodi1.NomTaula = "Orders";
            this.swCodi1.Requerit = false;
            this.swCodi1.Size = new System.Drawing.Size(504, 29);
            this.swCodi1.TabIndex = 5;
            // 
            // swTextbox2
            // 
            //this.swTextbox2.AlowEmpty = false;
            this.swTextbox2.CampBBDD = "idOrderInfo";
            this.swTextbox2.ControlAssociat = null;
            this.swTextbox2.IsForeignKey = false;
            this.swTextbox2.Location = new System.Drawing.Point(33, 266);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(100, 20);
            this.swTextbox2.TabIndex = 7;
            this.swTextbox2.TipoDato = SC_CustomControls.SWTextbox.tbxCont.nombre;
            // 
            // swTextbox3
            // 
            //this.swTextbox3.AlowEmpty = false;
            this.swTextbox3.CampBBDD = "idOrder";
            this.swTextbox3.ControlAssociat = "swCodi1";
            this.swTextbox3.IsForeignKey = false;
            this.swTextbox3.Location = new System.Drawing.Point(550, 297);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(100, 20);
            this.swTextbox3.TabIndex = 10;
            this.swTextbox3.TipoDato = SC_CustomControls.SWTextbox.tbxCont.nombre;
            // 
            // Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(921, 463);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swCodi1);
            this.Name = "Example";
            this.Controls.SetChildIndex(this.swCodi1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SC_CustomControls.SWCodi swCodi1;
        private SC_CustomControls.SWTextbox swTextbox2;
        private SC_CustomControls.SWTextbox swTextbox3;
    }
}