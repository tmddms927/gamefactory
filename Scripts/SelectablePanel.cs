﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_dream_is_owner
{
    class SelectablePanel : Panel
    {
        public SelectablePanel()
        {
            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true;
        }
    }
}
