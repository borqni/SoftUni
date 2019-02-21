function smallShop([product, town, quantity]) {
    quantity = Number(quantity);

    if (town == 'Sofia') {
        if (product == 'coffee') {
            console.log(0.50 * quantity);
        } else if (product == 'water') {
            console.log(0.80 * quantity);
        } else if (product == 'beer') {
            console.log(1.20 * quantity);
        } else if (product == 'sweets') {
            console.log(1.45 * quantity);
        } else if (product == 'peanuts') {
            console.log(1.60 * quantity);
        }
    } else if (town == 'Plovdiv') {
        if (product == 'coffee') {
            console.log(0.40 * quantity);
        } else if (product == 'water') {
            console.log(0.70 * quantity);
        } else if (product == 'beer') {
            console.log(1.15 * quantity);
        } else if (product == 'sweets') {
            console.log(1.30 * quantity);
        } else if (product == 'peanuts') {
            console.log(1.50 * quantity);
        }
    } else if (town == 'Varna') {
        if (product == 'coffee') {
            console.log(0.45 * quantity);
        } else if (product == 'water') {
            console.log(0.70 * quantity);
        } else if (product == 'beer') {
            console.log(1.10 * quantity);
        } else if (product == 'sweets') {
            console.log(1.35 * quantity);
        } else if (product == 'peanuts') {
            console.log(1.55 * quantity);
        }
    }
}