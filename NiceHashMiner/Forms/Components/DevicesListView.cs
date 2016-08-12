﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NiceHashMiner.Devices;

namespace NiceHashMiner.Forms.Components {
    public partial class DevicesListView : UserControl {
        public DevicesListView() {
            InitializeComponent();
        }


        public void SetComputeDevices(List<ComputeDevice> computeDevices) {
            foreach (var computeDevice in computeDevices) {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = computeDevice.Group;
                lvi.SubItems.Add(computeDevice.Name);
                lvi.Tag = computeDevice;
                listViewDevices.Items.Add(lvi);
            }
        }

        public void SetDeviceSelectionChangedCallback(ListViewItemSelectionChangedEventHandler callback) {
            listViewDevices.ItemSelectionChanged += callback;
        }

    }
}
