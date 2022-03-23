function Login() {
	var username = $("#txtUserName").val();
	var password = $("#txtPassword").val();
	if (username != "" && password != "") {
		$.ajax({
			url: "/Account/UserLogin",
			type: 'GET',
			contentType: 'application/json',
			data: { userName: username, password: password },
			success: function (response) {
				if (response == "success") {
					alert("Login is successfull.");
					window.location = "/Home/Index";
				}
				else {
					alert("Wrong credentials. Try again");
				}
			}
		});
		return false;
	}
	else {
		alert("Please enter username and password");
	}



}

function Registration() {
	var isValid = true;

	var fname = $("#fname").val();
	var lname = $("#lname").val();
	var address1 = $("#address1").val();
	var city = $("#city").val();
	var zip = $("#zip").val();
	var contact = $("#contact").val();
	var email = $("#email").val();
	var pass = $("#pass").val();
	var confirmpass = $("#confirmpass").val();
	var usertype = $('input[name="registrationtype"]:checked').val();



	if (fname != "" && lname != "" && address1 != "" && city != "" && zip != "" && contact != "" && email != "" && pass != "" &&
		confirmpass != "") {
		var namePattern = /^[a-zA-Z ]{2,30}$/;
		var fname = $("#fname").val().trim();
		if (fname == "") {
			$("#fname").prev().text("this field is required.");
			isValid = false;
		}
		else if (!namePattern.test(fname)) {
			$("#fname").prev().text("Please enter a valid name");
			isValid = false;
		}
		else {
			$("#fname").prev().text("");
		}
		$("#fname").val(fname);
		console.log("fnamepattern " + isValid);

		//lastname validation(same pattern as firstname)
		var lname = $("#lname").val().trim();
		if (lname == "") {
			$("#lname").prev().text("this field is required.");
			isValid = false;
		}
		else if (!namePattern.test(lname)) {
			$("#lname").prev().text("Please enter a valid name");
			isValid = false;
		}
		else {
			$("#lname").prev().text("");
		}
		$("#lname").val(lname);
		console.log("lnamepattern " + isValid);

		//address Validation
		var addresspattern = /^[a-zA-Z0-9-/. ]{5,30}$/;
		var address = $("#address1").val().trim();
		if (address == "") {
			$("#address1").prev().text("this field is required.");
			isValid = false;
		}
		else if (!addresspattern.test(address)) {
			"address cannot contain special characters except , / and ."
			isValid = false;
		}
		else {
			$("#address1").prev().text("");
		}
		$("#address1").val(address);
		console.log("address1 " + isValid);

		//address line 2 validation
		var address2 = $("#address2").val().trim();
		if (address2 == "") {
			$("#address2").prev().text("");
		}
		else if (!addresspattern.test(address)) {
			"address cannot contain special characters except , / and ."
			isValid = false;
		}
		else {
			$("#address2").prev().text("");
		}
		$("#address2").val(address2);
		console.log("address2 " + isValid);

		//city validation(yet same as namepattern)
		var city = $("#city").val().trim();
		if (city == "") {
			$("#city").prev().text("this field is required.");
			isValid = false;
		}
		else if (!namePattern.test(city)) {
			$("#city").prev().text("Please enter valid city name");
			isValid = false;
		}
		else {
			$("#city").prev().text("");
		}
		$("#city").val(city);
		console.log("city " + isValid);


		//zip validation
		var zippattern = /^(?!=.*[DFIOQU])[A-VXY0-9 ]{7}$/
		var zip = $("#zip").val().trim();
		if (zip == "") {
			$("#zip").prev().text("this field is required.");
			isValid = false;
		}
		else if (!zippattern.test(zip)) {
			$("#zip").prev().text("Please enter valid zip code");
			isValid = false;
		}
		else {
			$("#zip").prev().text("");
		}
		$("#zip").val(zip);
		console.log("zip " + isValid);

		//contact number validation
		var contactpattern = /^[0-9]{10}$/;
		var cnumber = $("#contact").val().trim();
		if (cnumber == "") {
			$("#contact").prev().text("this field is required.");
			isValid = false;
		}
		else if (!contactpattern.test(cnumber)) {
			$("#contact").prev().text("invalid contact. please check");
			isValid = false;
		}
		else {
			$("#contact").prev().text("");
		}
		$("#contact").val(cnumber);
		console.log("contactnumber " + isValid);

		//  email validation 
		var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;
		var email = $("#email").val().trim();
		if (email == "") {
			$("#email").prev().text("this field is required.");
			isValid = false;
		}
		else if (!emailPattern.test(email)) {
			$("#email").prev().text("Must be a valid email address.");
			isValid = false;
		}
		else {
			$("#email").prev().text("");
		}
		$("#email").val(email);
		console.log("email " + isValid);

		// password validation
		var passwordpattern = /^(?=.*[\d])(?=.*[a-z])(?=.*[A-Z])[A-Za-z\d]{4}$/;
		var pass = $("#pass").val().trim();

		if (pass == "") {
			$("#pass").prev().text("password cannot be empty.");
			isValid = false;
		}
		else if (!passwordpattern.test(pass)) {
			$("#pass").prev().text("password is not valid");
			isValid = false;
		}
		else {
			$("#pass").prev().text("");
		}
		$("#pass").val(pass);
		console.log("password " + isValid);

		//confirm password validation
		var confirmpass = $("#confirmpass").val().trim();
		if (!$("#confirmpass").val().trim()) {
			$("#confirmpass").prev().text("this field is required");
			isValid = false;
		}
		else if (confirmpass != pass) {
			$("#confirmpass").prev().text("passwords do not match");
			isValid = false;
		} else {
			$("#confirmpass").prev().text("passwords match");
		}
		$("#confirmpass").val(confirmpass);
		console.log("password2 " + isValid);

		// validation doctor/patient field
		if ((!$("#d_registration").is(":checked")) && !$("#p_registration").is(":checked")) {
			$("#displaycategory").text("select one of the options");
			isValid = false;
		}
		if (isValid == true) {
			var data = {
				"FirstName": fname, "LastName": lname, "Address1": address1, "Address2": address2, "City": city, "Zip": zip, "Contact": contact,
				"Email": email, "Password": pass, "Usertype": usertype
			};
			$.ajax({
				url: "/Account/UserRegistration",
				type: 'POST',
				contentType: 'application/json',
				async: true,
				data: JSON.stringify(data),
				success: function (response) {
					if (response == "success") {
						alert("Registration is successfull.");
						window.location = "/Account/Login";
					}

				}
			});
		}
	}
	else {
		alert("Please fill all the blanks   ");

	}
}




