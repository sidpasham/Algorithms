Design a parking lot with OOPs concepts

we need to make assumptions about the question, since there are none given.

abstract class Vehicle
	list parking spots
	license plate
	getspotsneeded
	vehiclesize
	parkinginSpot
	clearspots
	checkifvehiclecanfit

Bus, Car, Bike --> inherits Vehicle


Class ParkingLot
	list levels
	parkvehicle

Class Level
	list parkingspots
	available spots
	parkvehicle
	find available spots
	increase spots size when vehicle left

Class ParkingSpot
	Vehicle
	spotsize
	row
	level
	spotnumber
	isAvailble
	park
	getspotnumber
	removevehicle
