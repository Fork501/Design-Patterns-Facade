from Inspections import Electrical, Foundation, Plumbing, Roof


class BuildingFacade:

	def __init__(self):
		pass

	@classmethod
	def inspect_building(cls):
		to_return = ''

		electrical = Electrical()
		foundation = Foundation()
		plumbing = Plumbing()
		roof = Roof()

		to_return = to_return + electrical.inspect_wiring() + '\r\n'
		to_return = to_return + foundation.inspect_foundation() + '\r\n'
		to_return = to_return + plumbing.inspect_plumbing() + '\r\n'
		to_return = to_return + roof.inspect_roof() + '\r\n'

		return to_return
