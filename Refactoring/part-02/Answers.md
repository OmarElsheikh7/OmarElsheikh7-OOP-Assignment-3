# Part 02 — answers

---

## Reports

- What was the problem? : All exporters have the same logic for most methods in a redundant way.
- What did you change? : I created an abstract class that every child exporter implement.
- Why did you choose that approach? : Abstract class is a better here because it allows us to implement the shared workflow logic (`Load`, `Validate`, `Save`, and the `Export` template method itself) directly in the base class ,If we used an interface we could only add the method signatures Making us write the exact same file handling and validation code redundantly inside `CsvReportExporter`, `JsonReportExporter`, and `TextReportExporter`. 
					

---

## Enrollment

- What was the problem? : Program.cs was tightly coupled to the Enrollment system It had to manually create four different services and know the exact order required to process an enrollment.
- What did you change? : I created a new EnrollStudent Facade class with a single Enroll method that handles the services and executing the workflow then updated Program.cs to call the entire process using just that one method call.
- Why did you choose that approach? : This implements the Facade design pattern requested by the lab and It hides the complexity of the services (PaymentGateway, SeatInventory, InvoiceGenerator, and EmailService) from the caller.
