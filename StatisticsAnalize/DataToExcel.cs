using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsAnalize
{
	/// <summary>Класс передачи данных в Excel</summary>
	public static class DataToExcel
	{
		/// <summary>Вызов создания и открытие XLS-файла в Microsoft Excel</summary>
		/// <param name="exportDelegate">Метод выгрузки данных в файл, принимающий параметр "Путь"</param>
		/// <remarks>На папку временных файлов пользователя, Office ругается, считая её ненадёжным местом</remarks>
		public static void ExcelizeData(ExportDataToExcelDelegate exportDelegate)
		{
			// Формирование пути к файлу, лежащему во временной папке
			try
			{
				StringBuilder xlsPathBuilder = new StringBuilder(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
				xlsPathBuilder.Append("\\");
				xlsPathBuilder.Append(Guid.NewGuid().ToString());
				xlsPathBuilder.Append(".xls");

				string xlsPath = xlsPathBuilder.ToString();
				exportDelegate(xlsPath);

				object[] empty = new object[] { };

				Type excelApplication = Type.GetTypeFromProgID("Excel.Application");
				object application = Activator.CreateInstance(excelApplication);
				object workbooks = excelApplication.InvokeMember("Workbooks", System.Reflection.BindingFlags.GetProperty, null, application, empty);
				Type exсelWorkbooks = workbooks.GetType();
				exсelWorkbooks.InvokeMember("Open", System.Reflection.BindingFlags.InvokeMethod, null, workbooks, new object[] { xlsPath });
				excelApplication.InvokeMember("Visible", System.Reflection.BindingFlags.SetProperty, null, application, new object[] { true });
			}
			catch (Exception e)
			{
				throw new Exception("Ошибка выгрузки в Excel {" + exportDelegate.Method.Name + "}: " + e.Message);
			}
		}

		/// <summary>Делегат сохранения данных в XLS-файле по заданному пути</summary>
		/// <param name="path">Путь по которому должен бытьсохранён файл</param>
		public delegate void ExportDataToExcelDelegate(string path);

		internal static void ExcelizeData(object exportToExcelOld)
		{
			throw new NotImplementedException();
		}
	}
}
