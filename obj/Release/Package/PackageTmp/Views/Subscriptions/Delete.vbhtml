﻿@ModelType Subscription
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Radera</h2>

<h3>Är du säker på att du vill radera detta?</h3>
<div>
    <h4>Subscription</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.Label("Kund")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Customer.CustName )
        </dd>

        <dt>
            @Html.Label("Inervall")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PeriodType.PeriodTypeName)
        </dd>

        <dt>
            @Html.Label("Projekt")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Project.ProjectName)
        </dd>

        <dt>
            @Html.Label("Registrerad av")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserName)
        </dd>

        <dt>
            @Html.Label("Antal timmar")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NoOfHours)
        </dd>

        <dt>
            @Html.Label("Timpris")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PricePerHour)
        </dd>

        <dt>
            @Html.Label("Registrerad")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RegisteredDate)
        </dd>

        <dt>
            @Html.Label("Beskrivning")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        <dt>
            @Html.Label("Näst debitering")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastInvoiced)
        </dd>

        <dt>
            @Html.Label("Låst till användare")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LockedToUser)
        </dd>

        <dt>
            @Html.Label("Startdatum")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.StartDate)
        </dd>

        <dt>
            @Html.Label("Auto deb")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.AutoDeb)
        </dd>

        <dt>
            @Html.Label("Provision")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Commission)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-danger"  /> |
            @*@Html.ActionLink("Back to List", "AllCustomers")*@
             <a href='javascript:history.go(-1)'>Go Back</a>
        </div>
    End Using
</div>