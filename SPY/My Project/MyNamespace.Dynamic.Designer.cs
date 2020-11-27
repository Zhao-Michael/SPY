using System;
using System.ComponentModel;
using System.Diagnostics;

namespace SPY.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MessageHandle m_MessageHandle;

            public MessageHandle MessageHandle
            {
                [DebuggerHidden]
                get
                {
                    m_MessageHandle = Create__Instance__(m_MessageHandle);
                    return m_MessageHandle;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MessageHandle))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MessageHandle);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SpyForm m_SpyForm;

            public SpyForm SpyForm
            {
                [DebuggerHidden]
                get
                {
                    m_SpyForm = Create__Instance__(m_SpyForm);
                    return m_SpyForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SpyForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SpyForm);
                }
            }
        }
    }
}