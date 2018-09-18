from Facade import BuildingFacade


def main():
	building = BuildingFacade()

	print building.inspect_building()


if __name__ == '__main__':
	main()