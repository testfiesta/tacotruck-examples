import { defineConfig } from "vitest/config";

export default defineConfig({
  test: {
    watch: false,
    exclude: [],
    reporters: ["default", ["junit"]],
    outputFile: {
      junit: "./test-results.xml"
    }
  },
});
