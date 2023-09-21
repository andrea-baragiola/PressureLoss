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
            WaterFlowRate = new DataGridViewTextBoxColumn();
            PipeSurfaceFactor = new DataGridViewTextBoxColumn();
            NumberOf90DegCurves = new DataGridViewTextBoxColumn();
            NumberOf45DegCurves = new DataGridViewTextBoxColumn();
            NumberOfTJunctions = new DataGridViewTextBoxColumn();
            CalculateButton = new Button();
            outputText = new Label();
            resultDataGridView = new DataGridView();
            RTratto = new DataGridViewTextBoxColumn();
            RPipeLength = new DataGridViewTextBoxColumn();
            RPipeDiameter = new DataGridViewTextBoxColumn();
            RWaterFlowRate = new DataGridViewTextBoxColumn();
            UnitaryFrictionalPressureLoss = new DataGridViewTextBoxColumn();
            FrictionalPressureLoss = new DataGridViewTextBoxColumn();
            LocalPressureLoss = new DataGridViewTextBoxColumn();
            EquivalentLength = new DataGridViewTextBoxColumn();
            TotalPressureLoss = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)inputDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // inputDataGridView
            // 
            inputDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inputDataGridView.Columns.AddRange(new DataGridViewColumn[] { Tratto, PipeLength, PipeDiameter, WaterFlowRate, PipeSurfaceFactor, NumberOf90DegCurves, NumberOf45DegCurves, NumberOfTJunctions });
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
            // WaterFlowRate
            // 
            WaterFlowRate.HeaderText = "Water Flow Rate (l/s)";
            WaterFlowRate.Name = "WaterFlowRate";
            // 
            // PipeSurfaceFactor
            // 
            PipeSurfaceFactor.HeaderText = "SurfaceFactor";
            PipeSurfaceFactor.Name = "PipeSurfaceFactor";
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
            CalculateButton.Location = new Point(259, 258);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(265, 40);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // outputText
            // 
            outputText.AutoSize = true;
            outputText.Location = new Point(365, 314);
            outputText.Name = "outputText";
            outputText.Size = new Size(45, 15);
            outputText.TabIndex = 5;
            outputText.Text = "Output";
            // 
            // resultDataGridView
            // 
            resultDataGridView.AllowUserToAddRows = false;
            resultDataGridView.AllowUserToDeleteRows = false;
            resultDataGridView.AllowUserToOrderColumns = true;
            resultDataGridView.BackgroundColor = SystemColors.Window;
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { RTratto, RPipeLength, RPipeDiameter, RWaterFlowRate, UnitaryFrictionalPressureLoss, FrictionalPressureLoss, LocalPressureLoss, EquivalentLength, TotalPressureLoss });
            resultDataGridView.Location = new Point(53, 348);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowTemplate.Height = 25;
            resultDataGridView.Size = new Size(955, 150);
            resultDataGridView.TabIndex = 6;
            // 
            // RTratto
            // 
            RTratto.Frozen = true;
            RTratto.HeaderText = "Tratto";
            RTratto.Name = "RTratto";
            RTratto.ReadOnly = true;
            // 
            // RPipeLength
            // 
            RPipeLength.Frozen = true;
            RPipeLength.HeaderText = "Pipe Length (m)";
            RPipeLength.Name = "RPipeLength";
            RPipeLength.ReadOnly = true;
            // 
            // RPipeDiameter
            // 
            RPipeDiameter.Frozen = true;
            RPipeDiameter.HeaderText = "Pipe Diameter (mm)";
            RPipeDiameter.Name = "RPipeDiameter";
            RPipeDiameter.ReadOnly = true;
            // 
            // RWaterFlowRate
            // 
            RWaterFlowRate.Frozen = true;
            RWaterFlowRate.HeaderText = "Water Flow Rate (l/s)";
            RWaterFlowRate.Name = "RWaterFlowRate";
            RWaterFlowRate.ReadOnly = true;
            // 
            // UnitaryFrictionalPressureLoss
            // 
            UnitaryFrictionalPressureLoss.Frozen = true;
            UnitaryFrictionalPressureLoss.HeaderText = "Unitary Frictional Pressure Loss";
            UnitaryFrictionalPressureLoss.Name = "UnitaryFrictionalPressureLoss";
            UnitaryFrictionalPressureLoss.ReadOnly = true;
            // 
            // FrictionalPressureLoss
            // 
            FrictionalPressureLoss.Frozen = true;
            FrictionalPressureLoss.HeaderText = "Frictional Pressure Loss";
            FrictionalPressureLoss.Name = "FrictionalPressureLoss";
            FrictionalPressureLoss.ReadOnly = true;
            // 
            // LocalPressureLoss
            // 
            LocalPressureLoss.Frozen = true;
            LocalPressureLoss.HeaderText = "Local Pressure Loss";
            LocalPressureLoss.Name = "LocalPressureLoss";
            LocalPressureLoss.ReadOnly = true;
            // 
            // EquivalentLength
            // 
            EquivalentLength.Frozen = true;
            EquivalentLength.HeaderText = "Equivalent Length";
            EquivalentLength.Name = "EquivalentLength";
            EquivalentLength.ReadOnly = true;
            // 
            // TotalPressureLoss
            // 
            TotalPressureLoss.Frozen = true;
            TotalPressureLoss.HeaderText = "Total Pressure Loss ";
            TotalPressureLoss.Name = "TotalPressureLoss";
            TotalPressureLoss.ReadOnly = true;
            // 
            // PressureLossApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 596);
            Controls.Add(resultDataGridView);
            Controls.Add(outputText);
            Controls.Add(CalculateButton);
            Controls.Add(inputDataGridView);
            Name = "PressureLossApp";
            Text = "PressureLossApp";
            ((System.ComponentModel.ISupportInitialize)inputDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView inputDataGridView;
        private Button CalculateButton;
        private Label outputText;
        private DataGridView resultDataGridView;
        private DataGridViewTextBoxColumn RTratto;
        private DataGridViewTextBoxColumn RPipeLength;
        private DataGridViewTextBoxColumn RPipeDiameter;
        private DataGridViewTextBoxColumn RWaterFlowRate;
        private DataGridViewTextBoxColumn UnitaryFrictionalPressureLoss;
        private DataGridViewTextBoxColumn FrictionalPressureLoss;
        private DataGridViewTextBoxColumn LocalPressureLoss;
        private DataGridViewTextBoxColumn EquivalentLength;
        private DataGridViewTextBoxColumn TotalPressureLoss;
        private DataGridViewTextBoxColumn Tratto;
        private DataGridViewTextBoxColumn PipeLength;
        private DataGridViewTextBoxColumn PipeDiameter;
        private DataGridViewTextBoxColumn WaterFlowRate;
        private DataGridViewTextBoxColumn PipeSurfaceFactor;
        private DataGridViewTextBoxColumn NumberOf90DegCurves;
        private DataGridViewTextBoxColumn NumberOf45DegCurves;
        private DataGridViewTextBoxColumn NumberOfTJunctions;
    }
}