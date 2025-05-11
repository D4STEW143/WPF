using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_DataBase_Homework {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		Connector connector;

		Query[] queries = new Query[]
			{
				new Query("*", "Students JOIN Groups ON([group]=group_id) JOIN Directions ON(direction=direction_id)"),
				new Query(
					"group_id,group_name,COUNT(stud_id) AS students_count,direction_name",
					"Students,Groups,Directions",
					"direction=direction_id AND [group]=group_id",
					"group_id,group_name,direction_name"),
				new Query(
					@"direction_name,
                    COUNT(DISTINCT group_id) AS N'Количество групп',
                    COUNT(stud_id) AS N'Количество студентов'",
					@"Students
                    JOIN Groups ON ([group] = group_id)
                    RIGHT JOIN Directions ON (direction = direction_id)",
					"",
					"direction_name"), //Tables

				new Query("*", "Disciplines"),
				new Query("*", "Teachers"),
			};
		DataGrid[] tables;
		public MainWindow() {
			InitializeComponent();

			

			
		}
	}
}
