//-------------------------------------------------------------------------------
// <copyright file="IChildKernel.cs" company="bbv Software Services AG">
//   Copyright (c) 2010 Software Services AG
//   Remo Gloor (remo.gloor@gmail.com)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

using Ninject.Syntax;

namespace Ninject.Extensions.ChildKernel
{
    /// <summary>
    /// A kernel that has a parent for fall back.
    /// </summary>
    public interface IChildKernel : IKernel
    {
        /// <summary>
        /// Gets the parent resolution root.
        /// </summary>
        /// <value>The parent resolution root.</value>
        IResolutionRoot ParentResolutionRoot { get; }
    }
}