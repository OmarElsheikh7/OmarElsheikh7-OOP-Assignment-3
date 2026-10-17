namespace RefactoringLab.Part02.Enrollment;

using System;


public static class EnrollStudent
{
	public static void Enroll(string studentId,string courseId,decimal amount)
	{
        var payment = new PaymentGateway();
        var seats = new SeatInventory();
        var invoices = new InvoiceGenerator();
        var email = new EmailService();

        payment.Charge(studentId, amount);
        seats.Reserve(courseId, studentId);
        var invoiceId = invoices.Create(studentId, amount);
        email.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
    }
}
