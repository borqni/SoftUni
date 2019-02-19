function solve([age, pol]) {
    age = Number(age);

    if (pol == 'f') {
        if (age < 16) {
            console.log('Miss');
        } else {
            console.log('Ms.');
        }
    } else {
        if (age < 16) {
            console.log('Master')
        } else {
            console.log('Mr.')
        }
    }
}