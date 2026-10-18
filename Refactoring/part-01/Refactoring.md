# Part 01 — answers

---

## ShippingCostCalculator

**Problem:** The original calculator relied on string checks to determine the calculation logic violating the Open-Closed Principle.
**Solution:** Refactored using Polymorphism (the Strategy Pattern). The `Calculate` method now accepts the `IShippingCompany` interface making new carriers (like `Bosta`) to be added by simply creating new classes without modifying the calculator class itself.

---

## OrderProcessor

**Problem:** `OrderProcessor` was making instances of `SqlOrderRepository` and `SmtpEmailSender` using the `new` keyword in the `Process` method and This created tight coupling and violated the Dependency Inversion Principle.
**Solution:** Moved the database and email actions into `IOrderRepository` and `IEmailSender` interfaces and Implemented Constructor Injection so `OrderProcessor` receives these dependencies from the caller so this decouple the business logic from SQL and SMTP implementations.

---

## Notifications

**Problem:** The notification system used a big inhertance problem by making it nested for every case like (`UrgentScheduledSmsNotification`).
**Solution:** Applied Composition over Inheritance by Creating a common `INotificationChannel` interface so Base channels (`EmailChannel`, `SmsChannel`, `WhatsAppChannel`) handle the delivery while wrapper classes (`UrgentChannel`, `ScheduledChannel`) take an `INotificationChannel` in their constructor to modify the message before passing it down.

---

## Proof

- New carrier file(s): Bosta.cs
- New notification channel file(s): WhatsAppChannel
- Existing classes left unchanged? (yes/no): yes
