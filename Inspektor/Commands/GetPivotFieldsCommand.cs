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
                                 new PivotField{name = "Notes",type = "string",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "UsedBy",type = "string",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Year",type = "integer",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Month",type = "integer",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Day",type = "integer",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Hour",type = "integer",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Minute",type = "integer",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Usage",type = "integer",summarizable  = "count"}
                             };

            return fields;
        }
    }
}