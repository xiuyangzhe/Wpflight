using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using Wpflight.Model;

namespace Wpflight.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ///
            var tree = new ItemTreeData();
            tree.itemName = "第一级别";
            tree.itemId = 1;
            tree.Children.Add(new ItemTreeData() { itemId = 2,itemParent=1, itemName = "testtree", itemStep = 1 });
            _trees.Add(tree);
        }

        private ObservableCollection<ItemTreeData> _trees = new ObservableCollection<ItemTreeData>();

        public ObservableCollection<ItemTreeData> Trees
        {
            get
            {
                return _trees;
            }
            set => _trees = value;
        }
    }
}