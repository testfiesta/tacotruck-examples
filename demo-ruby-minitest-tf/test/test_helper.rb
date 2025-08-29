# frozen_string_literal: true

$LOAD_PATH.unshift File.expand_path("../lib", __dir__)
require "demo_ruby_minitest_tf"

require "minitest/autorun"
require "minitest/reporters"

Minitest::Reporters.use! Minitest::Reporters::JUnitReporter.new("test-reports")

# # Configure reporters based on environment
# if ENV['JUNIT_OUTPUT']
#   # Use JUnit reporter from minitest-reporters
#   # Extract directory and filename from the path
#   junit_path = ENV['JUNIT_OUTPUT']
#   junit_dir = File.dirname(junit_path)
  
#   # Ensure the directory exists
#   FileUtils.mkdir_p(junit_dir)
  
#   Minitest::Reporters.use! [
#     Minitest::Reporters::SpecReporter.new,
#     Minitest::Reporters::JUnitReporter.new(junit_dir, false)
#   ]
# else
#   # Use spec-style reporting for development
#   Minitest::Reporters.use! Minitest::Reporters::SpecReporter.new
# end
