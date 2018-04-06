function WizardSubmit(action, formId) {
    if (undefined == formId)
        formId = 0;
    document.forms[formId].action = "/" + action;
    document.forms[formId].submit();
}

var m_CurrentStep, m_TotalSteps, m_CanShowFinish;

function ShowWizardStep(wizardStepNumber) {
    $("#WizardStep_" + m_CurrentStep).removeClass("selected");
    $("#WizardStep_Div_" + m_CurrentStep).hide();
    $("#WizardStep_" + wizardStepNumber).addClass("selected");
    $("#WizardStep_Div_" + wizardStepNumber).show();
    m_CurrentStep = wizardStepNumber;
    ShowHideButtons();
}

function WizardNext() {
    if ($("#WizardForm0").valid()) {
        $("#WizardStep_" + m_CurrentStep).removeClass("selected");
        $("#WizardStep_Div_" + m_CurrentStep).hide("slide", { direction: "right" },
            function () {
                $("#WizardStep_" + m_CurrentStep).addClass("selected");
                m_CurrentStep = m_CurrentStep + 1;
                $("#WizardStep_Div_" + m_CurrentStep).show("slide", { direction: "left" });
                ShowHideButtons();
            });
    }

}

function WizardBack() {
    $("#WizardStep_" + m_CurrentStep).removeClass("selected");
    $("#WizardStep_Div_" + m_CurrentStep).hide("slide", { direction: "left" },
        function () {
            m_CurrentStep = m_CurrentStep - 1;
            $("#WizardStep_" + m_CurrentStep).addClass("selected");
            $("#WizardStep_Div_" + m_CurrentStep).show("slide", { direction: "right" });
            ShowHideButtons();
        });


}

function ShowHideButtons() {
    if (m_CurrentStep == 0)
        $("#BackButton").hide();
    else
        $("#BackButton").show();

    if (m_CurrentStep == (m_TotalSteps - 1))
        $("#NextButton").hide();
    else
        $("#NextButton").show();
    if (m_CurrentStep > 2)
        m_CanShowFinish = true;
    if (m_CanShowFinish == true)
        $("#FinishButton").show();
    else
        $("#FinishButton").hide();
}

function WizardInit(numberOfSteps) {
    m_CurrentStep = 0;
    m_TotalSteps = numberOfSteps;
    m_CanShowFinish = false;
    $("#WizardStep_0").addClass("selected");
    $("#WizardStep_Div_0").show();
    $("#BackButton").hide();
    $("#FinishButton").hide();

}

// Adds a new Operational Location row to the table
function AddOpLocationRow() {
    // get the field values
    var area = $("#area").val();
    var country = $("#country").val();
    var location = $("#location").val();

    // create the markup that needs to be added to the table
    var markup = "<tr><td><input type='checkbox' name='olRecord'></td><td>" + area + "</td><td>" + country + "</td><td>" + location + "</tr>";
    // append the markup to the tbody element of the specified table
    $("#opLocationInfo > tbody:last-child").append(markup);

    var itemList = [];
    // decode the JSON data in the hidden control
    var existingData = JSON.parse($("#opLocations").val());

    // create a new record using the field values entered
    var item = {
        OrganisationId: 0,
        OperationalAreaId: area,
        CountryId: country,
        Location: location
    };

    // check if this is the first record being inserted into the control
    if (existingData == []) {
        // push it into the blank array
        itemList.push(item);
        // encode the newly created array and save the data to the hidden control
        $("#opLocations").val(JSON.stringify(itemList));
    }
    else {
        // add the new entry to the existing decoded JSON data
        existingData.push(item);
        // encode the updated array and save the data to the hidden control
        $("#opLocations").val(JSON.stringify(existingData));
    }

    // clear the controls
    $("#area").val('');
    $("#country").val('');
    $("#location").val('');
}

// Removes the selected Operational location rows from the table
function RemoveOpLocationRow() {
    // get all the checkbox items
    $("#opLocationInfo tbody").find('input[name="olRecord"]').each(function (value, i) {
        // check if the checkbox is checked
        if ($(this).is(":checked")) {
            // remove the record form the table
            $(this).parents("tr").remove();
            // get the hidden control value and decode the JSON
            var existingData = JSON.parse($("#opLocations").val());
            // remove the item at the 'value' index
            existingData.splice(value, 1);
            // save the data back to the hidden control value
            $("#opLocations").val(JSON.stringify(existingData));
        }
    });
}

// shows or hides the previous grant info section depending on what selection is made
function DisplayPreviousGrantInfo() {
    if ($("#ReceivedPreviousGrant").is(":checked")) {
        // the checkbox is checked, so show the received previous grant table
        $("#previousGrantInfo").attr("class", "show");
    }
    else {
        // the checkbox is unchecked, so hide the received previous grant table
        $("#previousGrantInfo").attr("class", "hide");
    }
}

// Adds a new Previous Grant row to the table
function AddPreviousGrantRow() {
    // get the field values
    var projectName = $("#projectName").val();
    var grantId = $("#grantId").val();
    var keyOutcomes = $("#keyOutcomes").val();

    // create the markup that needs to be added to the table
    var markup = "<tr><td><input type='checkbox' name='rpgRecord'></td><td>" + projectName + "</td><td>" + grantId + "</td><td>" + keyOutcomes + "</tr>";
    // append the markup to the tbodyelement of the specified table
    $("#previousGrantInfo > tbody:last-child").append(markup); // ref: https://stackoverflow.com/questions/171027/add-table-row-in-jquery

    var itemList = [];
    // decode the JSON data in the hidden control
    var existingData = JSON.parse($("#previousGrants").val());

    // create a new record using the field values entered
    var item = {
        OrganisationId: 0,
        ProjectName: projectName,
        GrantId: grantId,
        KeyOutcomes: keyOutcomes
    };

    // check if this is the first record being inserted into the control
    if (existingData == []) {
        // push it into the blank array
        itemList.push(item);
        // encode the newly created array and save the data to the hidden control
        $("#previousGrants").val(JSON.stringify(itemList));
    }
    else {
        // add the new entry to the existing decoded JSON data
        existingData.push(item);
        // encode the updated array and save the data to the hidden control
        $("#previousGrants").val(JSON.stringify(existingData));
    }

    // clear the controls
    $("#projectName").val('');
    $("#grantId").val('');
    $("#keyOutcomes").val('');
}

// Removes the selected Previous Grant rows from the table
function RemovePreviousGrantRow(e) {
    // get all the checkbox items
    $("#previousGrantInfo tbody").find('input[name="rpgRecord"]').each(function (value, i) {
        // check if the checkbox is checked
        if ($(this).is(":checked")) {
            // remove the record form the table
            $(this).parents("tr").remove();
            // get the hidden control value and decode the JSON
            var existingData = JSON.parse($("#previousGrants").val());
            // remove the item at the 'value' index
            existingData.splice(value, 1);
            // save the data back to the hidden control value
            $("#previousGrants").val(JSON.stringify(existingData));
        }
    });
}