using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpflight.Model
{
    public class ItemTreeData : ObservableObject // 自定义Item的树形结构
    {
        public int itemId { get; set; }      // ID
        public string itemName { get; set; } // 名称
        public int itemStep { get; set; }    // 所属的层级
        public int itemParent { get; set; }  // 父级的ID

        private ObservableCollection<ItemTreeData> _children = new ObservableCollection<ItemTreeData>();
        public ObservableCollection<ItemTreeData> Children
        {  // 树形结构的下一级列表
            get
            {
                return _children;
            }
        }


        private bool _IsExpanded;
        public bool IsExpanded
        {
            get { return _IsExpanded; }
            set
            {
                _IsExpanded = value;
                RaisePropertyChanged(() => IsExpanded);
            }
        } // 节点是否展开

        private bool _isSelected;
        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }
            set
            {
                _isSelected = value;
                RaisePropertyChanged(() => IsSelected);
            }
        } // 节点是否选中
    }
}
