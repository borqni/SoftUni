function carFactory(input) {
    let car = {};
    car.model = input.model;
    let engine;

    if (input.power <= 90) {
        engine = {
            power: 90,
            volume: 1800
        }
    } else if (input.power <= 120) {
        engine = {
            power: 120,
            volume: 2400
        }
    } else if (input.power <= 200) {
        engine = {
            power: 200,
            volume: 3500
        }
    }
    car.engine = engine;

    car.carriage = {
        type: input.carriage,
        color: input.color
    };

    if (input.wheelsize % 2 === 0) {
        input.wheelsize--;
    }

    let wheels = [];
    for (let i = 0; i < 4; i++) {
        wheels.push(input.wheelsize);
    }
    car.wheels = wheels;

    return car;
}

carFactory({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
});