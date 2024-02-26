function setMinDate() {
    var currentDate = new Date().toISOString().split("T")[0];
    var dateInputs = document.querySelectorAll('input[type="date"]');

    for (var i = 0; i < dateInputs.length; i++) {
        dateInputs[i].min = currentDate;
    }
}