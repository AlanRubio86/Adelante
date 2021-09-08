using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using panelCitas;

namespace Adelante
{
    class PanelNodo
    {
        public panCitas paPanel;
        public int aiVal;

        public int dev;

        public panCitas _Pan
        {
            get { return paPanel; }
            set { paPanel = value; }
        }

        public int _Dev
        {
            get { return dev; }
            set { dev = value; }
        }

        public int _Val
        {
            get { return aiVal; }
            set { aiVal = value; }
        }
        public PanelNodo(panCitas pan, int val)
        {
            this.paPanel = pan;
            this.aiVal = val;
        }
    }
}
