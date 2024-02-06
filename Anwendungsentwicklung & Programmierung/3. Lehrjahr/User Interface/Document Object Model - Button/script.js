function berechnen()
	{
		var ticket_preis = 29;
		var anzahl = document.getElementById("Ticketanzahl").value;
		var ergebnis = anzahl * ticket_preis;
		
		document.getElementById("Ergebnis").textContent = `Der Gesamtpreis beträgt: ${ergebnis}`;
		/*document.getElementByID("Ergebnis").hidden = false;*/
	}