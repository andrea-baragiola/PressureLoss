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
            CalculateButton = new Button();
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
            tableLayoutPanelIO = new TableLayoutPanel();
            title = new Label();
            inputInstructionsLabel = new Label();
            tableLayoutPanelGeneral = new TableLayoutPanel();
            Tratto = new DataGridViewTextBoxColumn();
            PipeLength = new DataGridViewTextBoxColumn();
            PipeDiameter = new DataGridViewTextBoxColumn();
            WaterFlowRate = new DataGridViewTextBoxColumn();
            PipeSurfaceFactor = new DataGridViewTextBoxColumn();
            NumberOf90DegCurves = new DataGridViewTextBoxColumn();
            NumberOf45DegCurves = new DataGridViewTextBoxColumn();
            NumberOfTJunctions = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)inputDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            tableLayoutPanelIO.SuspendLayout();
            tableLayoutPanelGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // inputDataGridView
            // 
            inputDataGridView.BackgroundColor = SystemColors.Window;
            inputDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inputDataGridView.Columns.AddRange(new DataGridViewColumn[] { Tratto, PipeLength, PipeDiameter, WaterFlowRate, PipeSurfaceFactor, NumberOf90DegCurves, NumberOf45DegCurves, NumberOfTJunctions, Delete });
            inputDataGridView.Dock = DockStyle.Fill;
            inputDataGridView.Location = new Point(3, 53);
            inputDataGridView.Name = "inputDataGridView";
            inputDataGridView.RowTemplate.Height = 25;
            inputDataGridView.Size = new Size(765, 218);
            inputDataGridView.TabIndex = 3;
            inputDataGridView.CellContentClick += inputDataGridView_CellContentClick;
            inputDataGridView.DefaultValuesNeeded += inputDataGridView_DefaultValuesNeeded;
            // 
            // CalculateButton
            // 
            CalculateButton.Anchor = AnchorStyles.None;
            CalculateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateButton.Location = new Point(253, 281);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(265, 40);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // resultDataGridView
            // 
            resultDataGridView.AllowUserToAddRows = false;
            resultDataGridView.AllowUserToDeleteRows = false;
            resultDataGridView.AllowUserToOrderColumns = true;
            resultDataGridView.BackgroundColor = SystemColors.Window;
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { RTratto, RPipeLength, RPipeDiameter, RWaterFlowRate, UnitaryFrictionalPressureLoss, FrictionalPressureLoss, LocalPressureLoss, EquivalentLength, TotalPressureLoss });
            resultDataGridView.Dock = DockStyle.Fill;
            resultDataGridView.Location = new Point(3, 331);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowTemplate.Height = 25;
            resultDataGridView.Size = new Size(765, 216);
            resultDataGridView.TabIndex = 6;
            // 
            // RTratto
            // 
            RTratto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RTratto.HeaderText = "Tratto";
            RTratto.Name = "RTratto";
            RTratto.ReadOnly = true;
            // 
            // RPipeLength
            // 
            RPipeLength.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RPipeLength.HeaderText = "Pipe Length (m)";
            RPipeLength.Name = "RPipeLength";
            RPipeLength.ReadOnly = true;
            // 
            // RPipeDiameter
            // 
            RPipeDiameter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RPipeDiameter.HeaderText = "Pipe Diameter (mm)";
            RPipeDiameter.Name = "RPipeDiameter";
            RPipeDiameter.ReadOnly = true;
            // 
            // RWaterFlowRate
            // 
            RWaterFlowRate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RWaterFlowRate.HeaderText = "Water Flow Rate (l/s)";
            RWaterFlowRate.Name = "RWaterFlowRate";
            RWaterFlowRate.ReadOnly = true;
            // 
            // UnitaryFrictionalPressureLoss
            // 
            UnitaryFrictionalPressureLoss.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UnitaryFrictionalPressureLoss.HeaderText = "Unitary Frictional Pressure Loss";
            UnitaryFrictionalPressureLoss.Name = "UnitaryFrictionalPressureLoss";
            UnitaryFrictionalPressureLoss.ReadOnly = true;
            // 
            // FrictionalPressureLoss
            // 
            FrictionalPressureLoss.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FrictionalPressureLoss.HeaderText = "Frictional Pressure Loss";
            FrictionalPressureLoss.Name = "FrictionalPressureLoss";
            FrictionalPressureLoss.ReadOnly = true;
            // 
            // LocalPressureLoss
            // 
            LocalPressureLoss.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LocalPressureLoss.HeaderText = "Local Pressure Loss";
            LocalPressureLoss.Name = "LocalPressureLoss";
            LocalPressureLoss.ReadOnly = true;
            // 
            // EquivalentLength
            // 
            EquivalentLength.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EquivalentLength.HeaderText = "Equivalent Length";
            EquivalentLength.Name = "EquivalentLength";
            EquivalentLength.ReadOnly = true;
            // 
            // TotalPressureLoss
            // 
            TotalPressureLoss.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPressureLoss.HeaderText = "Total Pressure Loss ";
            TotalPressureLoss.Name = "TotalPressureLoss";
            TotalPressureLoss.ReadOnly = true;
            // 
            // tableLayoutPanelIO
            // 
            tableLayoutPanelIO.ColumnCount = 1;
            tableLayoutPanelIO.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelIO.Controls.Add(CalculateButton, 0, 3);
            tableLayoutPanelIO.Controls.Add(resultDataGridView, 0, 4);
            tableLayoutPanelIO.Controls.Add(title, 0, 0);
            tableLayoutPanelIO.Controls.Add(inputDataGridView, 0, 2);
            tableLayoutPanelIO.Controls.Add(inputInstructionsLabel, 0, 1);
            tableLayoutPanelIO.Dock = DockStyle.Fill;
            tableLayoutPanelIO.Location = new Point(3, 3);
            tableLayoutPanelIO.Name = "tableLayoutPanelIO";
            tableLayoutPanelIO.RowCount = 7;
            tableLayoutPanelIO.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelIO.RowStyles.Add(new RowStyle(SizeType.Percent, 3.84615374F));
            tableLayoutPanelIO.RowStyles.Add(new RowStyle(SizeType.Percent, 43.0769234F));
            tableLayoutPanelIO.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3846149F));
            tableLayoutPanelIO.RowStyles.Add(new RowStyle(SizeType.Percent, 42.6923065F));
            tableLayoutPanelIO.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelIO.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelIO.Size = new Size(771, 590);
            tableLayoutPanelIO.TabIndex = 7;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Dock = DockStyle.Fill;
            title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(765, 30);
            title.TabIndex = 7;
            title.Text = "Pressure Loss App";
            // 
            // inputInstructionsLabel
            // 
            inputInstructionsLabel.AutoSize = true;
            inputInstructionsLabel.Location = new Point(3, 30);
            inputInstructionsLabel.Name = "inputInstructionsLabel";
            inputInstructionsLabel.Size = new Size(435, 15);
            inputInstructionsLabel.TabIndex = 8;
            inputInstructionsLabel.Text = "Insert data in the following table, then click \"Calculate\" to execute the calculation\r\n";
            // 
            // tableLayoutPanelGeneral
            // 
            tableLayoutPanelGeneral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelGeneral.ColumnCount = 1;
            tableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.17949F));
            tableLayoutPanelGeneral.Controls.Add(tableLayoutPanelIO, 0, 0);
            tableLayoutPanelGeneral.Dock = DockStyle.Fill;
            tableLayoutPanelGeneral.Location = new Point(0, 0);
            tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral";
            tableLayoutPanelGeneral.RowCount = 1;
            tableLayoutPanelGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelGeneral.Size = new Size(777, 596);
            tableLayoutPanelGeneral.TabIndex = 8;
            // 
            // Tratto
            // 
            Tratto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tratto.HeaderText = "Tratto";
            Tratto.Name = "Tratto";
            Tratto.ReadOnly = true;
            // 
            // PipeLength
            // 
            PipeLength.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PipeLength.HeaderText = "Pipe Length (m)";
            PipeLength.Name = "PipeLength";
            // 
            // PipeDiameter
            // 
            PipeDiameter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PipeDiameter.HeaderText = "PipeDiameter (mm)";
            PipeDiameter.Name = "PipeDiameter";
            // 
            // WaterFlowRate
            // 
            WaterFlowRate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WaterFlowRate.HeaderText = "Water Flow Rate (l/s)";
            WaterFlowRate.Name = "WaterFlowRate";
            // 
            // PipeSurfaceFactor
            // 
            PipeSurfaceFactor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PipeSurfaceFactor.HeaderText = "Surface Factor";
            PipeSurfaceFactor.Name = "PipeSurfaceFactor";
            // 
            // NumberOf90DegCurves
            // 
            NumberOf90DegCurves.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NumberOf90DegCurves.HeaderText = "90° Curves (quantity)";
            NumberOf90DegCurves.Name = "NumberOf90DegCurves";
            // 
            // NumberOf45DegCurves
            // 
            NumberOf45DegCurves.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NumberOf45DegCurves.HeaderText = "45° Curves (quantity)";
            NumberOf45DegCurves.Name = "NumberOf45DegCurves";
            // 
            // NumberOfTJunctions
            // 
            NumberOfTJunctions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NumberOfTJunctions.HeaderText = "T. Junctions (quantity)";
            NumberOfTJunctions.Name = "NumberOfTJunctions";
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.Text = "Delete Row";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // PressureLossApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 596);
            Controls.Add(tableLayoutPanelGeneral);
            Name = "PressureLossApp";
            Text = "PressureLossApp";
            ((System.ComponentModel.ISupportInitialize)inputDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            tableLayoutPanelIO.ResumeLayout(false);
            tableLayoutPanelIO.PerformLayout();
            tableLayoutPanelGeneral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView inputDataGridView;
        private Button CalculateButton;
        private DataGridView resultDataGridView;
        private TableLayoutPanel tableLayoutPanelIO;
        private TableLayoutPanel tableLayoutPanelGeneral;
        private DataGridViewTextBoxColumn RTratto;
        private DataGridViewTextBoxColumn RPipeLength;
        private DataGridViewTextBoxColumn RPipeDiameter;
        private DataGridViewTextBoxColumn RWaterFlowRate;
        private DataGridViewTextBoxColumn UnitaryFrictionalPressureLoss;
        private DataGridViewTextBoxColumn FrictionalPressureLoss;
        private DataGridViewTextBoxColumn LocalPressureLoss;
        private DataGridViewTextBoxColumn EquivalentLength;
        private DataGridViewTextBoxColumn TotalPressureLoss;
        private Label title;
        private Label inputInstructionsLabel;
        private DataGridViewTextBoxColumn Tratto;
        private DataGridViewTextBoxColumn PipeLength;
        private DataGridViewTextBoxColumn PipeDiameter;
        private DataGridViewTextBoxColumn WaterFlowRate;
        private DataGridViewTextBoxColumn PipeSurfaceFactor;
        private DataGridViewTextBoxColumn NumberOf90DegCurves;
        private DataGridViewTextBoxColumn NumberOf45DegCurves;
        private DataGridViewTextBoxColumn NumberOfTJunctions;
        private DataGridViewButtonColumn Delete;
    }
}