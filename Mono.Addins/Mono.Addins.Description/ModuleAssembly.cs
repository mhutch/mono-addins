//
// ModuleDescription.cs
//
// Author:
//   Mikayla Hutchinson
//
// Copyright (C) 2016 Microsoft Corp (http://www.microsoft.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// W

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono.Addins.Description
{
	/// <summary>
	/// An assembly that is included in an addin module.
	/// </summary>
	public class ModuleAssembly
	{
		/// <summary>
		/// Path of the assembly relative to the addin.
		/// </summary>
		public string RelativePath { get; internal set; }

		/// <summary>
		/// Versions of this assembly to redirect to it.
		/// Format is '(version)[-(version)]' where (version) is an assembly version that may have a trailing * wildcard.
		/// For example: "1.0.0.*-*"
		/// </summary>
		public string RedirectVersion { get; internal set; }
	}
}
