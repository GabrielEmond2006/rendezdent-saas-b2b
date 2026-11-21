# RendezDent
![Architecture ClientPulse](docs/architecture.drawio.png)

Dentique is a multi-tenant B2B SaaS platform built for dental clinics to synchronize patient records, automate hygiene recall workflows, and maximize patient retention.

## Tech Stack

- Backend: C# / ASP.NET Core Web API (.NET)
- Database & ORM: PostgreSQL with Entity Framework Core (`Npgsql`)
- Frontend: React & TypeScript
- Payments & Subscriptions: Stripe SDK (`Stripe.net`)
- Authentication & Security: ASP.NET Core Identity & JWT (strict multi-tenant data isolation per clinic)
- Cloud & CI/CD: Microsoft Azure & GitHub Actions
