﻿#region Copyright 2014 Exceptionless

// This program is free software: you can redistribute it and/or modify it 
// under the terms of the GNU Affero General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
//     http://www.gnu.org/licenses/agpl-3.0.html

#endregion

using System;
using Exceptionless.Core.Utility;
using Exceptionless.Models;

namespace Exceptionless.Core.Plugins.WebHook {
    public class WebHookDataContext : ExtensibleObject {
        public WebHookDataContext(Version version, PersistentEvent ev, Organization organization = null, Project project = null, Stack stack = null, bool isNew = false, bool isRegression = false) {
            if (version == null)
                throw new ArgumentException("Version cannot be null.", "version");
            
            if (ev == null)
                throw new ArgumentException("Event cannot be null.", "ev");
            
            Version = version;
            Organization = organization;
            Project = project;
            Stack = stack;
            Event = ev;
            IsNew = isNew;
            IsRegression = isRegression;
        }

        public WebHookDataContext(Version version, Stack stack, Organization organization = null, Project project = null, bool isNew = false, bool isRegression = false) {
            if (version == null)
                throw new ArgumentException("Version cannot be null.", "version");

            if (stack == null)
                throw new ArgumentException("Stack cannot be null.", "stack");

            Version = version;
            Organization = organization;
            Project = project;
            Stack = stack;
            IsNew = isNew;
            IsRegression = isRegression;
        }

        public PersistentEvent Event { get; set; }
        public Stack Stack { get; set; }
        public Organization Organization { get; set; }
        public Project Project { get; set; }

        public Version Version { get; set; }
        public bool IsNew { get; set; }
        public bool IsRegression { get; set; }
    }
}