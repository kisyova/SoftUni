/**
 * Created by Kameliya on 25.7.2014 г..
 */
function findYoungestPerson(people) {
    var youngest = Number.MAX_VALUE;

    for(var i = 0; i < people.length; i++) {
        if(people[i] < youngest) {
            var result = people[i];
            youngest = people[i].age;
        }
    }
    if(result) {
        return "The youngest person is " + result.firstname + " " + result.lastname;
    }
    else {
        return "Age property is missing"
    }
}

var people = [
    { firstname : 'George', lastname: 'Kolev', age: 32},
    { firstname : 'Bay', lastname: 'Ivan', age: 81},
    { firstname : 'Baba', lastname: 'Ginka', age: 40}];
findYoungestPerson(people);