﻿using PnP.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PnP.Core.Modernization.Services.Core
{
    /// <summary>
    /// Abstract interface for a service that defines a list of pages to transform
    /// </summary>
    public interface ITransformationDistiller
    {
        /// <summary>
        /// Defines a list of Page Transformation Tasks
        /// </summary>
        /// <param name="SourceContext">The PnPContext of the source site</param>
        /// <param name="TargetContext">The PnPContext of the target site</param>
        /// <returns>A list of PageTransformationTask to transform</returns>
        Task<List<PageTransformationTask>> GetTransformationTasks(PnPContext SourceContext, PnPContext TargetContext);
    }
}
