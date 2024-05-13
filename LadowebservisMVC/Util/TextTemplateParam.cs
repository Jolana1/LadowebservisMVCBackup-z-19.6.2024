﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LadowebservisMVC.Util
{
    public class TextTemplateParam
    {/// <summary>
     /// Text template parameter
     /// </summary>
        
            string paramName;
            /// <summary>
            /// Gets or sets the template parameter name
            /// </summary>
            public string ParamName
            {
                get
                {
                    return paramName;
                }
                set
                {
                    paramName = value;
                }
            }

            string paramValue;
            /// <summary>
            /// Gets or sets the template parameter value
            /// </summary>
            public string ParamValue
            {
                get
                {
                    return paramValue;
                }
                set
                {
                    paramValue = value;
                }
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="TemplateParam"/> class.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            public TextTemplateParam(string name, string value)
            {
                paramName = name;
                paramValue = value;
            }
        }
    }

