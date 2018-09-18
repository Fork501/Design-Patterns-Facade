using Facade.Classes;
using System.Text;

namespace Facade.Facade
{
	public class BuildingFacade
	{
		public string InspectBuilding()
		{
			var toReturn = new StringBuilder();

			var electrical = new Electrical();
			var foundation = new Foundation();
			var plumbing = new Plumbing();
			var roof = new Roof();

			toReturn.AppendLine(electrical.InspectWiring());
			toReturn.AppendLine(foundation.InspectFoundation());
			toReturn.AppendLine(plumbing.InspectPlumbing());
			toReturn.AppendLine(roof.InspectRoof());

			return toReturn.ToString();
		}
	}
}
