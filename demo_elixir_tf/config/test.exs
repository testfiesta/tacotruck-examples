import Config

config :junit_formatter,
  report_file: "test-results.xml",
  report_dir: Path.expand("./test-reports"),
  print_report_file: true,
  automatic_create_dir?: true,
  include_timestamp: true,
  include_filename?: true
