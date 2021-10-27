cities = {'GA' : 'Atlanta', 'NY' : 'Albany', 'CA' : 'San Diego'}
if 'FL' in cities:
    del cities['FL']
cities['FL'] = 'Tallahassee'
print(cities)
