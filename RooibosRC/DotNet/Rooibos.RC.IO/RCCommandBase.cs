using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooibos.RC.IO
{
    public abstract class RCCommandBase<T> : IRCCommand<T>
    {
        protected T m_Value;

        public abstract string GetCommand();

        public virtual string GetValue()
        {
            return m_Value as string;
        }

        public T Value
        {
            get
            {
                return m_Value;
            }
            set
            {
                m_Value = value;
            }
        }
    }
}
