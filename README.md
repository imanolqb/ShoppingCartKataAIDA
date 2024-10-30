<a href="https://www.eii.ulpgc.es" target="_blank">
    <img src="https://www.eii.ulpgc.es/sites/default/files/eii-acron-mod.png" alt="EII-ULPGC" align="right" width="516" height="150" />
</a>
<a href="https://www.domingoalonsogroup.com" target="_blank">
    <img src="https://www.domingoalonsogroup.com/user/pages/02.empresas/aida/Logo%20AIDA.png" alt="AIDA" align="right" height="150" />
</a>

# Shopping Cart Kata
> Developed by Imanol Benito Quintero Bermúdez
> Exercise proposed by **Aplicaciones Informáticas Domingo Alonso (AIDA)** internship tutors as an intern in the Computer Engineering Degree at **ULPGC**

This project is a **kata** for creating a Shopping Cart application for an online grocery store. It follows **best programming practices** and **Test-Driven Development (TDD)** techniques to iteratively build the product.

## Objective
The kata aims to build a shopping cart system iteratively, focusing on precision in product pricing and unique item identification.

## Technical Requirements
- **Unit Price Calculation**: The unit price is calculated based on the product cost and the revenue margin desired by the company.
- **Rounding Rules**: Prices should be rounded up. For instance, if the calculated unit price is 1.7825, the rounded unit price will be 1.79.
- **Final Price with VAT**: The final product price includes VAT, rounded up accordingly.
- **Unique Product Names**: Products cannot share the same name.

## Project Setup
To run this project, ensure that you have .NET Core or .NET Framework installed, and clone the repository. Open the solution in Visual Studio and verify the following dependencies are included:
- `using FluentAssertions;`
- `using NUnit.Framework;`
