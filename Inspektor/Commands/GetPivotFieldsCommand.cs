using System.Collections.Generic;
using Inspektor.Entities;

namespace Inspektor.Commands
{
    /// <summary>
    /// Obtains the available fields for the pivot view
    /// </summary>
    public class GetPivotFieldsCommand:ICommand<string,IEnumerable<PivotField>>
    {
        public IEnumerable<PivotField> Execute( string parameters )
        {
            var fields = new[]
                             {
                                 new PivotField{name = "Application",type = "string",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Feature",type = "string",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "UsedBy",type = "string",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "UsedAt",type = "date",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Usage",type = "integer",summarizable  = "sum"}
                             };

            return fields;
        }
    }
}