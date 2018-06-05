using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationExamples
{
	public partial class TabPageDatabound : TabbedPage
	{
        public TabPageDatabound()
        {
            InitializeComponent();
            this.ItemsSource = new TabItem[] {
                new TabItem ("First", 1),
                new TabItem ("Second", 2),
                new TabItem ("Third", 3),
                new TabItem ("Fourth", 4),
                new TabItem ("Fifth", 5),
                new TabItem ("Sixth", 6)
            };
        }

        class TabItem
        {
            public TabItem(string name, int number)
            {
                this.Name = name;
                this.Number = number;
            }

            public string Name { private set; get; }
            public int Number { private set; get; }

        }
    }
}