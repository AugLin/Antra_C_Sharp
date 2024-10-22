// Problem 1
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};

var salary = 0;
for(let person in salaries) {
    salary = salary + salaries[person]; 
}
console.log(salary);


// Problem 2
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

function multiplyNumeric(){
    for(let key in menu) {
        if (typeof(menu[key]) === 'number') {
            menu[key] = menu[key] * 2;
        }
    }
}
multiplyNumeric();
console.log(menu);


// Problem 3
var email1 = 'example@gmail.com';
var email2 = 'example.gmail@com';

function checkEmail(email){
    var result = new Array(2);
    var counter = 0;

    for(let i = 0; i < email.length; i++) {
        if (email.charAt(i) === '@' || email.charAt(i) === '.') {
            result[counter++] = email.charAt(i);
        }
    }
    return result[0] === '@' && result[1] === '.';
}

console.log(checkEmail(email1));
console.log(checkEmail(email2));


// Problem 4
function truncate(s, max) {
    var result = [];
    for(let i = 0; i < s.length && i < max-1; i++) {
        result.push(s.charAt(i));
    }
    if (result.length === max - 1) {
        result.push('...');
    }
    console.log(result.join(""));
}

truncate("What I'd like to tell on this topic is:", 20);
truncate("Hi Everyone!", 20);

// Problem 5
var arr = ['James', 'Brennie'];
console.log(arr);
arr.push('Robert');
console.log(arr);
var middle = arr.length / 2;
arr[Math.round(middle)-1] = 'Calvin';
console.log(arr);
arr.splice(0, 1);
console.log(arr);
arr.unshift('Regal');
arr.unshift('Rose');
console.log(arr);
