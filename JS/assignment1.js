// 1.
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}

let totalSalary = 0;

for (let key in salaries) {
    totalSalary += salaries[key];
}

// console.log(totalSalary);

// 2.
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

for (let key in menu) {
    if (Number.isInteger(menu[key])) {
        menu[key] = menu[key] * 2;
    }
}

// console.log(menu);

//3.
const checkEmailId = (str) => {
    str = str.toLowerCase();

    let atIndex = str.indexOf('@');
    let dotIndex = str.indexOf('.');

    if (atIndex !== -1 && dotIndex !== -1 && atIndex < dotIndex) {
        if (dotIndex - atIndex > 1) {
            return true;
        }
    }

    return false;
}

//4.
const truncate = (str, maxlength) => {
    if (str.length > maxlength) {
        let newString = str.slice(0, maxlength - 3);
        return newString + "...";
    }
    return str;
};

//5.
let myArray = ["James", "Brennie"];
myArray.push("Robert");
let middleIndex = Math.floor(myArray.length / 2);
myArray[middleIndex] = "Calvin";
myArray.shift();
myArray.unshift("Regal");
myArray.unshift("Rose");