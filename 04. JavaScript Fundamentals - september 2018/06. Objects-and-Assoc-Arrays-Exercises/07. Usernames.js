function usernames(input) {
    let usernames = new Set();

    input.forEach(name => usernames.add(name));

    Array.from(usernames)
        .sort((a, b) => a.length - b.length || a.localeCompare(b))
        .forEach(u => console.log(u));
}

usernames(['Ashton',
    'Kutcher',
    'Ariel',
    'Lilly',
    'Keyden',
    'Aizen',
    'Billy',
    'Braston'
])