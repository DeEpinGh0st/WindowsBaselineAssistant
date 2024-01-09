using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsBaselineAssistant
{
    internal class Report
    {
        public static void AutoSizeColumns(ISheet sheet)
        {
            int x = sheet.GetRow(1).LastCellNum;
            for (int i = 0; i < sheet.GetRow(1).LastCellNum; i++)
            {
                sheet.AutoSizeColumn(i);
            }
        }

        public static void AddSystemInfoRow(ISheet sheet)
        {
            try
            {
                // 在表格最上方插入一行
                IRow systemInfoRow = sheet.CreateRow(0);

                // 添加单元格内容
                string sheetTitle = $"" +
                    $"Windows安全基线检测/加固结果汇总表\n" +
                    $"系统版本:{Util.GetOSVersion()}   IP地址:{Util.GetIPAddress()}   主机名:{Environment.MachineName}";
                systemInfoRow.CreateCell(0).SetCellValue(sheetTitle);

                // 创建样式
                ICellStyle cellStyle = sheet.Workbook.CreateCellStyle();
                IFont font = sheet.Workbook.CreateFont();

                // 设置底色为浅绿色
                cellStyle.FillForegroundColor = IndexedColors.LightGreen.Index;
                cellStyle.FillPattern = FillPattern.SolidForeground;

                // 设置字体为粗体和加大
                font.Boldweight = (short)FontBoldWeight.Bold;
                font.FontHeightInPoints = 14;
                // 启用自动换行
                cellStyle.WrapText = true;
                // 设置文本水平居中
                cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                // 应用样式和字体到单元格
                cellStyle.SetFont(font);
                systemInfoRow.Cells[0].CellStyle = cellStyle;

                // 合并前7个单元格
                sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, 6));
                // 调整行高
                systemInfoRow.HeightInPoints = 3 * sheet.DefaultRowHeightInPoints; // 根据需要调整行高

            }
            catch (Exception)
            {

                throw;
            }

        }



        [Obsolete]
        public static void WriteDataGridViewToExcel(DataGridView dataGridView, ISheet sheet)
        {
            try
            {
                // 创建表头的样式
                ICellStyle headerStyle = sheet.Workbook.CreateCellStyle();
                headerStyle.FillForegroundColor = IndexedColors.LightGreen.Index;
                headerStyle.FillPattern = FillPattern.SolidForeground;

                IFont headerFont = sheet.Workbook.CreateFont();
                headerFont.Boldweight = (short)FontBoldWeight.Bold;
                headerFont.FontHeightInPoints = 14; // 设置字体大小
                headerStyle.SetFont(headerFont);

                // 创建单元格样式
                ICellStyle cellStyle = sheet.Workbook.CreateCellStyle();



                // 写入表头
                IRow headerRow = sheet.CreateRow(1);
                for (int i = 0; i < dataGridView.Columns.Count - 1; i++) // 不输出最后一列数据
                {
                    NPOI.SS.UserModel.ICell cell = headerRow.CreateCell(i);
                    cell.SetCellValue(dataGridView.Columns[i].HeaderText);
                    cell.CellStyle = headerStyle;
                }

                // 写入数据行
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewRow dataGridViewRow = dataGridView.Rows[i];
                    IRow excelRow = sheet.CreateRow(i + 2);

                    for (int j = 0; j < dataGridViewRow.Cells.Count - 1; j++) // 不输出最后一列数据
                    {
                        DataGridViewCell dataGridViewCell = dataGridViewRow.Cells[j];
                        NPOI.SS.UserModel.ICell cell = excelRow.CreateCell(j);
                        cell.SetCellValue(dataGridViewCell.Value?.ToString() ?? "");

                        // 根据倒数第二列的值设置单元格底色
                        string valueInSecondLastColumn = dataGridView.Rows[i].Cells[dataGridView.Columns.Count - 2].Value?.ToString();
                        SetCellStyleBasedOnValue(cell, valueInSecondLastColumn);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        static void SetCellStyleBasedOnValue(NPOI.SS.UserModel.ICell cell, string value)
        {
            try
            {
                ICellStyle cellStyle = cell.Sheet.Workbook.CreateCellStyle();

                switch (value)
                {
                    case "符合":
                        cellStyle.FillForegroundColor = IndexedColors.LightGreen.Index;
                        break;
                    case "不符合":
                        cellStyle.FillForegroundColor = IndexedColors.Coral.Index;
                        break;
                    default:
                        cellStyle.FillForegroundColor = IndexedColors.LightYellow.Index;
                        break;
                }

                cellStyle.FillPattern = FillPattern.SolidForeground;
                cell.CellStyle = cellStyle;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
