//pobranie elementu po id
var contact = document.getElementById('linkedin');

//deklaracja fukcji, wy�wietlaj�cej alert
function getInformationEventHandler() {
    alert('Funkcjonalność w remoncie.');
};

//reakcja na klikni�cie na pobrany element
contact.addEventListener('click', getInformationEventHandler, false);
