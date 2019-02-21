function voleyball([arg1, arg2, arg3]) {
    let year = (arg1);
    let holiday = Number(arg2);
    let weekends = Number(arg3);
    let sofiaPlays = 0;
    sofiaPlays += (48 - weekends) * 3 / 4;
    sofiaPlays += (holiday) * 2 / 3;
    let totalPlays = sofiaPlays + weekends;
    if (year == 'leap') {
        totalPlays += totalPlays * 15 / 100;
    }

    console.log(Math.floor(totalPlays));
}