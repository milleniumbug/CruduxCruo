using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CruduxCruo.WPF
{
    /// <summary>
    /// Interaction logic for DataCreatorBox.xaml
    /// </summary>
    public partial class DataCreatorBox : UserControl
    {
        public DataCreatorBox()
        {
            InitializeComponent();
        }

        public Type InstanceType
        {
            get { return (Type)GetValue(InstanceTypeProperty); }
            set { SetValue(InstanceTypeProperty, value); }
        }

        public static readonly DependencyProperty InstanceTypeProperty =
            DependencyProperty.Register("InstanceType", typeof(Type), typeof(DataCreatorBox), new PropertyMetadata(null, OnInstanceTypeChanged));

        private static void OnInstanceTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var self = (DataCreatorBox)d;
            var newValue = (Type)e.NewValue;
            var gridLengthConverter = new GridLengthConverter();
            self.Properties.Children.Clear();
            self.Properties.ColumnDefinitions.Add(new ColumnDefinition());
            self.Properties.ColumnDefinitions.Add(new ColumnDefinition());
            int currentRow = 0;

            //var hasErrorProp = typeof(INotifyDataErrorInfo).GetProperty();
            foreach (var property in newValue.GetProperties().Where(prop => prop.Name != nameof(INotifyDataErrorInfo.HasErrors)))
            {
                self.Properties.RowDefinitions.Add(new RowDefinition
                {
                    Height = length("Auto")
                });
                {
                    var block = new TextBlock();
                    block.Text = property.GetCustomAttributes(typeof(DescriptionAttribute), false)
                        .OfType<DescriptionAttribute>()
                        .SingleOrDefault()
                        ?.Description ?? property.Name;
                    self.Properties.Children.Add(block);
                    Grid.SetColumn(block, 0);
                    Grid.SetRow(block, currentRow);

                }
                currentRow++;
            }
            self.Properties.RowDefinitions.Add(new RowDefinition
            {
                Height = length("*")
            });

            GridLength length(string len)
            {
                return (GridLength)gridLengthConverter.ConvertFromString(len);
            }
        }

        private static VanceStubbs factory

        /*private static TypeDictionary<Func<UIElement>> UiFactory = new TypeDictionary<Func<UIElement>>
        {

        };*/

        public object Create()
        {
            return null;
        }
    }
}
