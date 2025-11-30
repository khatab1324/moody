import Fastify, { FastifyInstance } from "fastify";

const fastify: FastifyInstance = Fastify({
  logger: true,
});
fastify.get("/", async function (request, reply) {
  reply.send({ hello: "world" });
});

fastify.listen({ port: 3100 }, function (err, address) {
  if (err) {
    fastify.log.error(err);
    process.exit(1);
  }
  console.log(`Server listening on ${address}`);
});
export {};
