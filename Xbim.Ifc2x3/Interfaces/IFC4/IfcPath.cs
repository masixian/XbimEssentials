// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.TopologyResource
{
	public partial class @IfcPath : IIfcPath
	{

		[CrossSchemaAttribute(typeof(IIfcPath), 1)]
		IItemSet<IIfcOrientedEdge> IIfcPath.EdgeList 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcOrientedEdge, IIfcOrientedEdge>(EdgeList);
			} 
		}
	//## Custom code
	//##
	}
}