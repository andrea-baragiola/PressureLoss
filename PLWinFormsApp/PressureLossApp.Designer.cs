namespace PLWinFormsApp
{
    partial class PressureLossApp
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
            inputDataGridView = new DataGridView();
            Tratto = new DataGridViewTextBoxColumn();
            PipeLength = new DataGridViewTextBoxColumn();
            PipeDiameter = new DataGridViewTextBoxColumn();
            PipeSurfaceFactor = new DataGridViewTextBoxColumn();
            WaterFlowRate = new DataGridViewTextBoxColumn();
            NumberOf90DegCurves = new DataGridViewTextBoxColumn();
            NumberOf45DegCurves = new DataGridViewTextBoxColumn();
            NumberOfTJunctions = new DataGridViewTextBoxColumn();
            CalculateButton = new Button();
            outputText = new Label();
            ((System.ComponentModel.ISupportInitialize)inputDataGridView).BeginInit();
            SuspendLayout();
            // 
            // inputDataGridView
            // 
            inputDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inputDataGridView.Columns.AddRange(new DataGridViewColumn[] { Tratto, PipeLength, PipeDiameter, PipeSurfaceFactor, WaterFlowRate, NumberOf90DegCurves, NumberOf45DegCurves, NumberOfTJunctions });
            inputDataGridView.Location = new Point(44, 97);
            inputDataGridView.Name = "inputDataGridView";
            inputDataGridView.RowTemplate.Height = 25;
            inputDataGridView.Size = new Size(820, 142);
            inputDataGridView.TabIndex = 3;
            inputDataGridView.DefaultValuesNeeded += inputDataGridView_DefaultValuesNeeded;
            // 
            // Tratto
            // 
            Tratto.HeaderText = "Tratto";
            Tratto.Name = "Tratto";
            Tratto.ReadOnly = true;
            Tratto.Width = 77;
            // 
            // PipeLength
            // 
            PipeLength.HeaderText = "Pipe Length (m)";
            PipeLength.Name = "PipeLength";
            // 
            // PipeDiameter
            // 
            PipeDiameter.HeaderText = "PipeDiameter (mm)";
            PipeDiameter.Name = "PipeDiameter";
            // 
            // PipeSurfaceFactor
            // 
            PipeSurfaceFactor.HeaderText = "SurfaceFactor";
            PipeSurfaceFactor.Name = "PipeSurfaceFactor";
            // 
            // WaterFlowRate
            // 
            WaterFlowRate.HeaderText = "Water Flow Rate (l/s)";
            WaterFlowRate.Name = "WaterFlowRate";
            // 
            // NumberOf90DegCurves
            // 
            NumberOf90DegCurves.HeaderText = "90° Curves (quantity)";
            NumberOf90DegCurves.Name = "NumberOf90DegCurves";
            // 
            // NumberOf45DegCurves
            // 
            NumberOf45DegCurves.HeaderText = "45° Curves (quantity)";
            NumberOf45DegCurves.Name = "NumberOf45DegCurves";
            // 
            // NumberOfTJunctions
            // 
            NumberOfTJunctions.HeaderText = "T. Junctions (quantity)";
            NumberOfTJunctions.Name = "NumberOfTJunctions";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(425, 275);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 23);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // outputText
            // 
            outputText.AutoSize = true;
            outputText.Location = new Point(438, 338);
            outputText.Name = "outputText";
            outputText.Size = new Size(45, 15);
            outputText.TabIndex = 5;
            outputText.Text = "Output";
            // 
            // PressureLossApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 487);
            Controls.Add(outputText);
            Controls.Add(CalculateButton);
            Controls.Add(inputDataGridView);
            Name = "PressureLossApp";
            Text = "PressureLossApp";
            ((System.ComponentModel.ISupportInitialize)inputDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView inputDataGridView;
        private DataGridViewTextBoxColumn Tratto;
        private DataGridViewTextBoxColumn PipeLength;
        private DataGridViewTextBoxColumn PipeDiameter;
        private DataGridViewTextBoxColumn PipeSurfaceFactor;
        private DataGridViewTextBoxColumn WaterFlowRate;
        private DataGridViewTextBoxColumn NumberOf90DegCurves;
        private DataGridViewTextBoxColumn NumberOf45DegCurves;
        private DataGridViewTextBoxColumn NumberOfTJunctions;
        private Button CalculateButton;
        private Label outputText;
    }
}