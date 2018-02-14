# test-automation
Example API project used for practising automated testing.

The applications runs at http://localhost:50000

Swagger is located at http://localhost:50000/swagger

There are two endpoints:
* GET /api/health
* POST /api/calculations/calculateTotalAmount

Example JSON model to post to the endpoint to calculate 2% interest over 5 years on 1000.

```json
{
  "principal": 1000,
  "percentageRate": 2,
  "years": 5
}
```
