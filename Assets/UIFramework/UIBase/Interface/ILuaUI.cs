﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLua;

namespace UIFramework
{
    public interface ILuaUI
    {
        string[] OnGetEvents();

        void OnAwake();

        void OnStart(params object[] args);

        void OnEnable();

        void OnDisable();

        void OnDestroy();

        void OnNotifiy(string evt, params object[] args);
    }
}
