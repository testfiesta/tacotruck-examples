# frozen_string_literal: true

$LOAD_PATH.unshift File.expand_path("../lib", __dir__)
require "demo_ruby_minitest_tf"

require "minitest/autorun"
require "minitest/reporters"

Minitest::Reporters.use! Minitest::Reporters::JUnitReporter.new("test-reports")
