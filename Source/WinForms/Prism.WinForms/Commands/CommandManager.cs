using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Prism.Commands
{
    public class CommandManager 
    {
        private IList<ICommandBinder> Binders { get; set; }

        public CommandManager()
        {
            Binders = new List<ICommandBinder>
                          {
                              new ButtonBinder(),
                              new MenuItemCommandBinder()
                          };           
        }

        public CommandManager Bind(ICommand command, IComponent component)
        {
            FindBinder(component).Bind(command, component);
            return this;
        }

        protected ICommandBinder FindBinder(IComponent component)
        {
            var binder = GetBinderFor(component);

            if (binder == null)
                throw new Exception(string.Format("No binding found for component of type {0}", component.GetType().Name));

            return binder;
        }

        private ICommandBinder GetBinderFor(IComponent component)
        {
            var type = component.GetType();
            while (type != null)
            {
                var binder = Binders.FirstOrDefault(x => x.SourceType == type);
                if (binder != null)
                    return binder;

                type = type.BaseType;
            }

            return null;
        }
    }
}

